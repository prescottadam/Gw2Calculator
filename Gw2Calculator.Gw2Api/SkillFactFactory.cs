using System;
using System.Collections.Generic;
using System.Linq;
using Gw2Calculator.Models;
using Gw2Calculator.Models.SkillFacts;
using Newtonsoft.Json.Linq;

namespace Gw2Calculator.Gw2Api
{
    public class SkillFactFactory
    {
        private readonly Dictionary<SkillFactTypeEnum, Func<JToken, ISkillFact>> _map;

        public SkillFactFactory()
        {
            _map = new Dictionary<SkillFactTypeEnum, Func<JToken, ISkillFact>>
            {
                { SkillFactTypeEnum.AttributeAdjust, CreateAttributeAdjustFact },
                { SkillFactTypeEnum.Buff, CreateBuffFact },
                { SkillFactTypeEnum.ComboField, CreateComboFieldFact },
                { SkillFactTypeEnum.ComboFinisher, CreateComboFinisherFact },
                { SkillFactTypeEnum.Damage, CreateDamageFact },
                { SkillFactTypeEnum.Distance, CreateDistanceFact },
                { SkillFactTypeEnum.Duration, CreateDurationFact },
                { SkillFactTypeEnum.Heal, CreateHealFact },
                { SkillFactTypeEnum.HealingAdjust, CreateHealingAdjustFact },
                { SkillFactTypeEnum.NoData, CreateNoDataFact },
                { SkillFactTypeEnum.Number, CreateNumberFact },
                { SkillFactTypeEnum.Percent, CreatePercentFact },
                { SkillFactTypeEnum.PrefixedBuff, CreatePrefixedBuffFact },
                { SkillFactTypeEnum.Radius, CreateRadiusFact },
                { SkillFactTypeEnum.Range, CreateRangeFact },
                { SkillFactTypeEnum.Recharge, CreateRechargeFact },
                { SkillFactTypeEnum.StunBreak, CreateStunBreakFact },
                { SkillFactTypeEnum.Time, CreateTimeFact },
                { SkillFactTypeEnum.Unblockable, CreateUnblockableFact }
            };
        }

        public ISkillFact CreateFact(JToken fact)
        {
            SkillFactTypeEnum type;

            if (fact.Children<JProperty>().Any(x => x.Name == "type"))
            {
                type = Enum.Parse<SkillFactTypeEnum>(fact.Value<string>("type"));
            }
            else if (fact.Children<JProperty>().Any(x => x.Name == "percent"))
            {
                type = SkillFactTypeEnum.Percent;
            }
            else
            {
                throw new ArgumentException($"Unable to determine fact type for skill {fact.Value<string>("text")}");
            }

            if (_map.ContainsKey(type))
            {
                return _map[type](fact);
            }
            return null;
        }

        private ISkillFact CreateAttributeAdjustFact(JToken fact)
        {
            return new AttributeAdjustFact
            { 
                Value = fact.Value<int>("value"),
                Target = fact.Value<string>("target")
            };
        }

        private ISkillFact CreateBuffFact(JToken fact)
        {
            return new BuffFact
            {
                Status = fact.Value<string>("status"),
                Description = fact.Value<string>("description"),
                Counts = fact.Value<int?>("apply_count"),
                Duration = fact.Value<int?>("duration")
            };
        }

        private ISkillFact CreateComboFieldFact(JToken fact)
        {
            return new ComboFieldFact
            {
                FieldType = Enum.Parse<ComboFieldTypeEnum>(fact.Value<string>("field_type"))
            };
        }

        private ISkillFact CreateComboFinisherFact(JToken fact)
        {
            return new ComboFinisherFact
            {
                FinisherType = Enum.Parse<ComboFinisherTypeEnum>(fact.Value<string>("finisher_type")),
                Percent = fact.Value<int>("percent")
            };
        }

        private ISkillFact CreateDamageFact(JToken fact)
        {
            return new DamageFact
            {
                Hits = fact.Value<int>("hit_count"),
                Multiplier = fact.Value<decimal>("dmg_multiplier")
            };
        }

        private ISkillFact CreateDistanceFact(JToken fact)
        {
            return new DistanceFact
            {
                Distance = fact.Value<int>("distance")
            };
        }

        private ISkillFact CreateDurationFact(JToken fact)
        {
            return new DurationFact
            {
                Duration = fact.Value<int>("duration")
            };
        }

        private ISkillFact CreateHealFact(JToken fact)
        {
            return new HealFact
            {
                Hits = fact.Value<int>("hit_count"),
            };
        }

        private ISkillFact CreateHealingAdjustFact(JToken fact)
        {
            return new HealingAdjustFact
            {
                Hits = fact.Value<int>("hit_count"),
            };
        }

        private ISkillFact CreateNoDataFact(JToken fact)
        {
            return new NoDataFact();
        }

        private ISkillFact CreateNumberFact(JToken fact)
        {
            return new NumberFact
            {
                Value = fact.Value<int?>("value"),
                Percent = fact.Value<int?>("percent")
            };
        }

        private ISkillFact CreatePercentFact(JToken fact)
        {
            return new PercentFact
            {
                Percent = fact.Value<int>("percent"),
            };
        }

        private ISkillFact CreatePrefixedBuffFact(JToken fact)
        {
            return new PrefixedBuffFact
            {
                Status = fact.Value<string>("status"),
                Description = fact.Value<string>("description"),
                Counts = fact.Value<int?>("apply_count"),
                Duration = fact.Value<int?>("duration"),
                Prefix = CreateBuffFact(fact.Value<JToken>("prefix")) as BuffFact
            };
        }

        private ISkillFact CreateRadiusFact(JToken fact)
        {
            return new RadiusFact
            {
                Distance = fact.Value<int>("distance")
            };
        }

        private ISkillFact CreateRangeFact(JToken fact)
        {
            return new RangeFact
            {
                Value = fact.Value<int>("value")
            };
        }

        private ISkillFact CreateRechargeFact(JToken fact)
        {
            return new RechargeFact
            {
                Value = fact.Value<int>("value")
            };
        }

        private ISkillFact CreateStunBreakFact(JToken fact)
        {
            return new StunBreakFact
            {
                Value = fact.Value<bool>("value")
            };
        }

        private ISkillFact CreateTimeFact(JToken fact)
        {
            return new TimeFact
            {
                Duration = fact.Value<int>("duration")
            };
        }

        private ISkillFact CreateUnblockableFact(JToken fact)
        {
            return new UnblockableFact
            {
                Value = fact.Value<bool>("value")
            };
        }
    }
}
