﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vMenuClient
{
    class PedScenarios
    {
        public static List<string> PositionBasedScenarios = new List<string>()
        {
            "PROP_HUMAN_SEAT_ARMCHAIR",
            "PROP_HUMAN_SEAT_BAR",
            "PROP_HUMAN_SEAT_BENCH",
            "PROP_HUMAN_SEAT_BUS_STOP_WAIT",
            "PROP_HUMAN_SEAT_CHAIR",
            "PROP_HUMAN_SEAT_CHAIR_UPRIGHT",
            "PROP_HUMAN_SEAT_CHAIR_MP_PLAYER",
            "PROP_HUMAN_SEAT_COMPUTER",
            "PROP_HUMAN_SEAT_DECKCHAIR",
            //"PROP_HUMAN_SEAT_DECKCHAIR_DRINK",
            //"PROP_HUMAN_SEAT_MUSCLE_BENCH_PRESS",
            //"PROP_HUMAN_SEAT_MUSCLE_BENCH_PRESS_PRISON",
            "PROP_HUMAN_SEAT_STRIP_WATCH",
            "PROP_HUMAN_SEAT_SUNLOUNGER",
            "WORLD_HUMAN_SEAT_LEDGE",
            "WORLD_HUMAN_SEAT_STEPS",
            "WORLD_HUMAN_SEAT_WALL",
        };

        /// <summary>
        /// All scenario names (readable version) linked to the actual scenario strings (code names).
        /// </summary>
        public static ConcurrentDictionary<string, string> ScenarioNames = new ConcurrentDictionary<string, string>
        {
            ["AA Drink Coffee"] = "WORLD_HUMAN_AA_COFFEE",
            ["AA Smoke Cig"] = "WORLD_HUMAN_AA_SMOKE",
            ["Binoculars"] = "WORLD_HUMAN_BINOCULARS",
            ["Bum Freeway"] = "WORLD_HUMAN_BUM_FREEWAY",
            ["Bum Slumped"] = "WORLD_HUMAN_BUM_SLUMPED",
            ["Bum Standing"] = "WORLD_HUMAN_BUM_STANDING",
            ["Bum Wash"] = "WORLD_HUMAN_BUM_WASH",
            ["Car Park Attendant"] = "WORLD_HUMAN_CAR_PARK_ATTENDANT",
            ["Cheering"] = "WORLD_HUMAN_CHEERING",
            ["Clipboard"] = "WORLD_HUMAN_CLIPBOARD",
            ["Constant Drilling"] = "WORLD_HUMAN_CONST_DRILL",
            ["Cop Idle"] = "WORLD_HUMAN_COP_IDLES",
            ["Drinking"] = "WORLD_HUMAN_DRINKING",
            ["Drug Dealer"] = "WORLD_HUMAN_DRUG_DEALER",
            ["Drug Dealer Hard"] = "WORLD_HUMAN_DRUG_DEALER_HARD",
            ["Mobile Film Shocking"] = "WORLD_HUMAN_MOBILE_FILM_SHOCKING",
            ["Garderner Leaf Blower"] = "WORLD_HUMAN_GARDENER_LEAF_BLOWER",
            ["Garderner Plant"] = "WORLD_HUMAN_GARDENER_PLANT",
            ["Golf Player"] = "WORLD_HUMAN_GOLF_PLAYER",
            ["Guard Patrol"] = "WORLD_HUMAN_GUARD_PATROL",
            ["Guard Stand"] = "WORLD_HUMAN_GUARD_STAND",
            ["Hamering"] = "WORLD_HUMAN_HAMMERING",
            ["Hang Out Street"] = "WORLD_HUMAN_HANG_OUT_STREET",
            ["Hiker Standing"] = "WORLD_HUMAN_HIKER_STANDING",
            ["Human Statue"] = "WORLD_HUMAN_HUMAN_STATUE",
            ["Janitor"] = "WORLD_HUMAN_JANITOR",
            ["Jog Standing"] = "WORLD_HUMAN_JOG_STANDING",
            ["Leaning"] = "WORLD_HUMAN_LEANING",
            ["Maid Clean"] = "WORLD_HUMAN_MAID_CLEAN",
            ["Muscle Flex"] = "WORLD_HUMAN_MUSCLE_FLEX",
            ["Muscle Free Weights"] = "WORLD_HUMAN_MUSCLE_FREE_WEIGHTS",
            ["Musician"] = "WORLD_HUMAN_MUSICIAN",
            ["Paparazzi"] = "WORLD_HUMAN_PAPARAZZI",
            ["Partying"] = "WORLD_HUMAN_PARTYING",
            ["Picnic"] = "WORLD_HUMAN_PICNIC",
            ["Prostitue High Class"] = "WORLD_HUMAN_PROSTITUTE_HIGH_CLASS",
            ["Prostitue Low Class"] = "WORLD_HUMAN_PROSTITUTE_LOW_CLASS",
            ["Pushups"] = "WORLD_HUMAN_PUSH_UPS",
            ["Seat Ledge"] = "WORLD_HUMAN_SEAT_LEDGE", //
            ["Seat Steps"] = "WORLD_HUMAN_SEAT_STEPS", //
            ["Seat Wall"] = "WORLD_HUMAN_SEAT_WALL", // 
            ["Security Shine Torch"] = "WORLD_HUMAN_SECURITY_SHINE_TORCH",
            ["Situps"] = "WORLD_HUMAN_SIT_UPS",
            ["Smoking"] = "WORLD_HUMAN_SMOKING",
            ["Smoking Pot"] = "WORLD_HUMAN_SMOKING_POT",
            ["Stand Fire"] = "WORLD_HUMAN_STAND_FIRE",
            ["Stand Fishing"] = "WORLD_HUMAN_STAND_FISHING",
            ["Stand Impatient"] = "WORLD_HUMAN_STAND_IMPATIENT",
            ["Stand Impatient Upright"] = "WORLD_HUMAN_STAND_IMPATIENT_UPRIGHT",
            ["Stand Mobile"] = "WORLD_HUMAN_STAND_MOBILE",
            ["Stand Mobile Upright"] = "WORLD_HUMAN_STAND_MOBILE_UPRIGHT",
            ["Stripclub Watch Stand"] = "WORLD_HUMAN_STRIP_WATCH_STAND",
            ["Stupor"] = "WORLD_HUMAN_STUPOR",
            ["Sunbathe"] = "WORLD_HUMAN_SUNBATHE",
            ["Sunbathe Back"] = "WORLD_HUMAN_SUNBATHE_BACK",
            ["Tennis Player"] = "WORLD_HUMAN_TENNIS_PLAYER",
            ["Tourist Map"] = "WORLD_HUMAN_TOURIST_MAP",
            ["Tourist Mobile"] = "WORLD_HUMAN_TOURIST_MOBILE",
            ["Vehicle Mechanic"] = "WORLD_HUMAN_VEHICLE_MECHANIC",
            ["Welding"] = "WORLD_HUMAN_WELDING",
            ["Window Shop Browse"] = "WORLD_HUMAN_WINDOW_SHOP_BROWSE",
            ["Yoga"] = "WORLD_HUMAN_YOGA",
            ["ATM"] = "PROP_HUMAN_ATM",
            ["BBQ"] = "PROP_HUMAN_BBQ",
            ["Bum Bin"] = "PROP_HUMAN_BUM_BIN",
            ["Bum Shopping Cart"] = "PROP_HUMAN_BUM_SHOPPING_CART",
            ["Muscle Chin Ups"] = "PROP_HUMAN_MUSCLE_CHIN_UPS",
            ["Muscle Chin Ups Army"] = "PROP_HUMAN_MUSCLE_CHIN_UPS_ARMY",
            ["Muscle Chin Ups Prison"] = "PROP_HUMAN_MUSCLE_CHIN_UPS_PRISON",
            ["Parking Meter"] = "PROP_HUMAN_PARKING_METER",
            ["Seat Armchair"] = "PROP_HUMAN_SEAT_ARMCHAIR", //
            ["Seat Bar"] = "PROP_HUMAN_SEAT_BAR", //
            ["Seat Bench"] = "PROP_HUMAN_SEAT_BENCH", //
            ["Seat Bus Stop Wait"] = "PROP_HUMAN_SEAT_BUS_STOP_WAIT", //
            ["Seat Chair"] = "PROP_HUMAN_SEAT_CHAIR", //
            ["Seat Chair Upright"] = "PROP_HUMAN_SEAT_CHAIR_UPRIGHT", //
            ["Seat MP Player"] = "PROP_HUMAN_SEAT_CHAIR_MP_PLAYER", //
            ["Seat Computer"] = "PROP_HUMAN_SEAT_COMPUTER", //
            ["Seat Deckchair"] = "PROP_HUMAN_SEAT_DECKCHAIR", // 
            ["Seat Deckchair Drink"] = "PROP_HUMAN_SEAT_DECKCHAIR_DRINK", // 
            ["Seat Muscle Bench Press"] = "PROP_HUMAN_SEAT_MUSCLE_BENCH_PRESS", // 
            ["Seat Muscle Bench Press Prison"] = "PROP_HUMAN_SEAT_MUSCLE_BENCH_PRESS_PRISON", //
            ["Seat Stripclub Watch"] = "PROP_HUMAN_SEAT_STRIP_WATCH", //
            ["Seat Sunlounger"] = "PROP_HUMAN_SEAT_SUNLOUNGER", //
            ["Stand Impatient"] = "PROP_HUMAN_STAND_IMPATIENT",
            ["Cross Road Wait"] = "CODE_HUMAN_CROSS_ROAD_WAIT",
            ["Medic Kneel"] = "CODE_HUMAN_MEDIC_KNEEL",
            ["Medic Tend To Dead"] = "CODE_HUMAN_MEDIC_TEND_TO_DEAD",
            ["Medic Time Of Death"] = "CODE_HUMAN_MEDIC_TIME_OF_DEATH",
            ["Police Crowd Control"] = "CODE_HUMAN_POLICE_CROWD_CONTROL",
            ["Police Investigate"] = "CODE_HUMAN_POLICE_INVESTIGATE",
        };

        /// <summary>
        /// A list containing all readable strings.
        /// </summary>
        public static List<string> Scenarios = new List<string>
        {
            "AA Drink Coffee",
            "AA Smoke Cig",
            "Binoculars",
            "Bum Freeway",
            "Bum Slumped",
            "Bum Standing",
            "Bum Wash",
            "Car Park Attendant",
            "Cheering",
            "Clipboard",
            "Constant Drilling",
            "Cop Idle",
            "Drinking",
            "Drug Dealer",
            "Drug Dealer Hard",
            "Mobile Film Shocking",
            "Garderner Leaf Blower",
            "Garderner Plant",
            "Golf Player",
            "Guard Patrol",
            "Guard Stand",
            "Hamering",
            "Hang Out Street",
            "Hiker Standing",
            "Human Statue",
            "Janitor",
            "Jog Standing",
            "Leaning",
            "Maid Clean",
            "Muscle Flex",
            "Muscle Free Weights",
            "Musician",
            "Paparazzi",
            "Partying",
            "Picnic",
            "Prostitue High Class",
            "Prostitue Low Class",
            "Pushups",
            "Seat Ledge",
            "Seat Steps",
            "Seat Wall",
            "Security Shine Torch",
            "Situps",
            "Smoking",
            "Smoking Pot",
            "Stand Fire",
            "Stand Fishing",
            "Stand Impatient",
            "Stand Impatient Upright",
            "Stand Mobile",
            "Stand Mobile Upright",
            "Stripclub Watch Stand",
            "Stupor",
            "Sunbathe",
            "Sunbathe Back",
            "Tennis Player",
            "Tourist Map",
            "Tourist Mobile",
            "Vehicle Mechanic",
            "Welding",
            "Window Shop Browse",
            "Yoga",
            "ATM",
            "BBQ",
            "Bum Bin",
            "Bum Shopping Cart",
            "Muscle Chin Ups",
            "Muscle Chin Ups Army",
            "Muscle Chin Ups Prison",
            "Parking Meter",
            "Seat Armchair",
            "Seat Bar",
            "Seat Bench",
            "Seat Bus Stop Wait",
            "Seat Chair",
            "Seat Chair Upright",
            "Seat MP Player",
            "Seat Computer",
            "Seat Deckchair",
            "Seat Deckchair Drink",
            "Seat Muscle Bench Press",
            "Seat Muscle Bench Press Prison",
            "Seat Stripclub Watch",
            "Seat Sunlounger",
            "Stand Impatient",
            "Cross Road Wait",
            "Medic Kneel",
            "Medic Tend To Dead",
            "Medic Time Of Death",
            "Police Crowd Control",
            "Police Investigate",
        };
    }
}
