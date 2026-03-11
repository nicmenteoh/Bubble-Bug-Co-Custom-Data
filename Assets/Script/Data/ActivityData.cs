using System.Collections.Generic;
using ZeroFormatter;

namespace ProjectPestHuntData
{
    [ZeroFormattable]
    public class NewLocation
    {
        [Index (0)] public virtual string location_id { get; set; }
        [Index (1)] public virtual string material_to_unlock_location { get; set; }
        [Index (2)] public virtual int min_activity_clear_count_to_unlock { get; set; }
    }


    #region ACT1 - Wood Cabin
    [ZeroFormattable]
    public class WoodCabinActivityData : BaseData
    {
        [ZeroFormattable]
        public class UnitQuantity
        {
            [Index (0)] public virtual IList<string> units { get; set; }
            [Index (1)] public virtual int quantity { get; set; }
        }

        [ZeroFormattable]
        public class LayerUnit
        {
            [Index (0)] public virtual int appear_poll { get; set; }
            [Index (1)] public virtual UnitQuantity layer_1_units { get; set; }
            [Index (2)] public virtual UnitQuantity layer_2_units { get; set; }
            [Index (3)] public virtual UnitQuantity layer_3_units { get; set; }
            [Index (4)] public virtual UnitQuantity layer_4_units { get; set; }
            [Index (5)] public virtual UnitQuantity layer_5_units { get; set; }
        }
        [ZeroFormattable]
        public class RepairHoleUnit
        {
            [Index (0)] public virtual string unit { get; set; }
            [Index (1)] public virtual int fill { get; set; }
        }
        [Index (1)] public virtual IList<LayerUnit> in_hole_unit_group { get; set; }
        [Index (2)] public virtual int initial_hole_appear_chance { get; set; }
        [Index (3)] public virtual int hole_chance_increase { get; set; }
        [Index (4)] public virtual IList<string> hole_discover_units { get; set; }
        [Index (5)] public virtual string material_to_lure_unit { get; set; }
        [Index (6)] public virtual string material_to_repair_hole { get; set; }
        [Index (7)] public virtual int total_hunt_to_fill_hole { get; set; }
        [Index (8)] public virtual IList<RepairHoleUnit> unit_to_boost_fill_hole { get; set; }
        [Index (9)] public virtual NewLocation to_new_location { get; set; }
        [Index (10)] public virtual string hole_discover_message_id { get; set; }
        [Index (11)] public virtual string next_unit_layer_message_id { get; set; }
        [Index (12)] public virtual string layer_unit_clear_message_id { get; set; }
        [Index (13)] public virtual string fully_repair_message_id { get; set; }
    }
    #endregion

    #region ACT2 - Wood House
    [ZeroFormattable]
    public class WoodHouseActivityData : BaseData
    {
        [ZeroFormattable]
        public class UnitSpeed
        {
            [Index (0)] public virtual IList<string> units { get; set; }
            [Index (1)] public virtual int start_speed_percentage { get; set; }
        }
        [ZeroFormattable]
        public class UnitRageQuantity
        {
            [Index (0)] public virtual int rage { get; set; }
            [Index (1)] public virtual int quantity { get; set; }
        }
        [ZeroFormattable]
        public class UnitMudDig
        {
            [Index (0)] public virtual string unit { get; set; }
            [Index (1)] public virtual int dig { get; set; }
        }
        [Index (1)] public virtual IList<UnitSpeed> party_unit_group { get; set; }
        [Index (2)] public virtual float start_speed { get; set; }
        [Index (3)] public virtual float final_speed { get; set; }
        [Index (4)] public virtual int speed_increase_percentage { get; set; }
        [Index (5)] public virtual int speed_decrease_percentage { get; set; }
        [Index (6)] public virtual string material_to_slow_speed { get; set; }
        [Index (7)] public virtual IList<UnitRageQuantity> party_unit_rage_quantity { get; set; }
        [Index (8)] public virtual int initial_party_start_chance { get; set; }
        [Index (9)] public virtual int party_chance_increase { get; set; }
        [Index (10)] public virtual IList<string> units_to_start_party { get; set; }
        [Index (11)] public virtual IList<UnitMudDig> units_to_dig_mud { get; set; }
        [Index (12)] public virtual int mud_dig_quantity { get; set; }
        [Index (13)] public virtual IList<string> units_to_drop_key { get; set; }
        [Index (14)] public virtual string key_to_unlock_room { get; set; }
        [Index (15)] public virtual int key_quantity_to_unlock_room { get; set; }
        [Index (16)] public virtual NewLocation to_new_location { get; set; }
        [Index (17)] public virtual string party_start_message_id { get; set; }
        [Index (18)] public virtual string mud_clear_message_id { get; set; }
        [Index (19)] public virtual string unit_runaway_message_id { get; set; }
        [Index (20)] public virtual string storage_clear_message_id { get; set; }
    }
    #endregion

}