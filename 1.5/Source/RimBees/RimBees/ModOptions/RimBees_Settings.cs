﻿using RimWorld;
using System;
using UnityEngine;
using Verse;


namespace RimBees
{
    public class RimBees_Settings : ModSettings

    {


        public static bool RB_IgnoreNight = false;
        public static bool RB_IgnoreRain = false;
        public static bool RB_IgnoreTemperature = false;
        public static bool RB_IgnorePlants = false;
        public static bool RB_GreenhouseBees = false;
        public static bool RB_DisableMessages = false;
        public static bool RB_Ben_ShowMissingBees = true; 
        public static bool RB_Ben_ShowProgress = true;
        public static bool RB_Ben_KnownBees = true;
        public static bool RB_Ben_BeeDangerAlert = true;
        public static bool RB_CarryBees = true;

        public static float beeProductionMultiplier = beeProductionMultiplierBase;
        public const float beeProductionMultiplierBase = 1f;

        public static int beeEffectRadius = beeEffectRadiusBase;
        public const int beeEffectRadiusBase = 6;



        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look(ref RB_IgnoreNight, "RB_IgnoreNight", false, true);
            Scribe_Values.Look(ref RB_IgnoreRain, "RB_IgnoreRain", false, true);
            Scribe_Values.Look(ref RB_IgnoreTemperature, "RB_IgnoreTemperature", false, true);
            Scribe_Values.Look(ref RB_IgnorePlants, "RB_IgnorePlants", false, true);
            Scribe_Values.Look(ref RB_GreenhouseBees, "RB_GreenhouseBees", false, true);
            Scribe_Values.Look(ref RB_DisableMessages, "RB_DisableMessages", false, true);
            Scribe_Values.Look(ref RB_Ben_ShowMissingBees, "RB_Ben_ShowMissingBees", true, true);
            Scribe_Values.Look(ref RB_Ben_ShowProgress, "RB_Ben_ShowProgress", true, true);
            Scribe_Values.Look(ref RB_Ben_KnownBees, "RB_Ben_KnownBees", true, true);
            Scribe_Values.Look(ref RB_Ben_BeeDangerAlert, "RB_Ben_BeeDangerAlert", true, true);
            Scribe_Values.Look(ref RB_CarryBees, "RB_CarryBees", true, true);
            Scribe_Values.Look(ref beeProductionMultiplier, "beeProductionMultiplier", beeProductionMultiplierBase, true);
            Scribe_Values.Look(ref beeEffectRadius, "beeEffectRadius", beeEffectRadiusBase, true);



        }
        public static void DoWindowContents(Rect inRect)
        {
            Listing_Standard ls = new Listing_Standard();

            ls.Begin(inRect);
            ls.ColumnWidth = inRect.width / 1f;

            ls.CheckboxLabeled("RB_IgnoreNight".Translate(), ref RB_IgnoreNight, null);

            ls.CheckboxLabeled("RB_IgnoreRain".Translate(), ref RB_IgnoreRain, null);

            ls.CheckboxLabeled("RB_IgnoreTemperature".Translate(), ref RB_IgnoreTemperature, null);

            ls.CheckboxLabeled("RB_IgnorePlants".Translate(), ref RB_IgnorePlants, null);

            ls.CheckboxLabeled("RB_GreenhouseBees".Translate(), ref RB_GreenhouseBees, null);

            ls.CheckboxLabeled("RB_DisableMessages".Translate(), ref RB_DisableMessages, null);

            ls.CheckboxLabeled("BenLubarsRimBeesPatches_showMissingBees_title".Translate(), ref RB_Ben_ShowMissingBees, "BenLubarsRimBeesPatches_showMissingBees_desc".Translate());

            ls.CheckboxLabeled("BenLubarsRimBeesPatches_showProgress_title".Translate(), ref RB_Ben_ShowProgress, "BenLubarsRimBeesPatches_showProgress_desc".Translate());

            ls.CheckboxLabeled("BenLubarsRimBeesPatches_knownBees_title".Translate(), ref RB_Ben_KnownBees, "BenLubarsRimBeesPatches_knownBees_desc".Translate());

            ls.CheckboxLabeled("BenLubarsRimBeesPatches_beeDangerAlert_title".Translate(), ref RB_Ben_BeeDangerAlert, "BenLubarsRimBeesPatches_beeDangerAlert_desc".Translate());

            ls.CheckboxLabeled("RB_CarryBees".Translate(), ref RB_CarryBees, "RB_CarryBees_Description".Translate());

            var beeProductionLabel = ls.LabelPlusButton("RB_BeeProductionMultiplier".Translate() + ": " + beeProductionMultiplier, "RB_BeeProductionMultiplierTooltip".Translate());
            beeProductionMultiplier = (float)Math.Round(ls.Slider(beeProductionMultiplier, 1, 10), 1);

            if (ls.Settings_Button("RB_Reset".Translate(), new Rect(0f, beeProductionLabel.position.y + 35, 250f, 29f)))
            {
                beeProductionMultiplier = beeProductionMultiplierBase;
            }
            var beeEffectRadiusLabel = ls.LabelPlusButton("RB_BeehouseEffectRadius".Translate() + ": " + beeEffectRadius, "RB_BeehouseEffectRadiusTooltip".Translate());
            beeEffectRadius = (int)Math.Round(ls.Slider(beeEffectRadius, 1, 12), 0);

            if (ls.Settings_Button("RB_Reset".Translate(), new Rect(0f, beeEffectRadiusLabel.position.y + 35, 250f, 29f)))
            {
                beeEffectRadius = beeEffectRadiusBase;
            }

            ls.End();

        }




    }

   

}
