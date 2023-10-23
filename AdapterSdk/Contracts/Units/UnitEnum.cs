using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Mtconnect.AdapterSdk.Units {
	/// <summary>
	/// Helper resources for Unit usage within the MTConnect Standard
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter; Adapter.UnitStaticHelper.scriban", "1.0.12.0")]
	public static class UnitHelper {
		/// <summary>
		/// A lookup relating observational types to their respective unit. See <see cref="Mtconnect.AdapterSdk.DataItemTypes.SampleTypes" />, <see cref="Mtconnect.AdapterSdk.DataItemTypes.EventTypes" />, and <see cref="Mtconnect.AdapterSdk.DataItemTypes.ConditionTypes" /> for keys. <b>NOTE</b>: this collection only contains observational types, not sub-types.
		/// </summary>
		public static readonly Dictionary<string, MtconnectUnit> TypeLookup = new Dictionary<string, MtconnectUnit>() {

			{ "ACCELERATION", MtconnectUnit.MILLIMETER_PER_SECOND_SQUARED },

			{ "ACCUMULATED_TIME", MtconnectUnit.SECOND },

			{ "AMPERAGE", MtconnectUnit.AMPERE },

			{ "ANGLE", MtconnectUnit.DEGREE },

			{ "ANGULAR_ACCELERATION", MtconnectUnit.DEGREE_PER_SECOND_SQUARED },

			{ "ANGULAR_VELOCITY", MtconnectUnit.DEGREE_PER_SECOND },

			{ "AXIS_FEEDRATE", MtconnectUnit.MILLIMETER_PER_SECOND },

			{ "CAPACITY_FLUID", MtconnectUnit.MILLILITER },

			{ "CAPACITY_SPATIAL", MtconnectUnit.CUBIC_MILLIMETER },

			{ "CONCENTRATION", MtconnectUnit.PERCENT },

			{ "CONDUCTIVITY", MtconnectUnit.SIEMENS_PER_METER },

			{ "CUTTING_SPEED", MtconnectUnit.MILLIMETER_PER_SECOND },

			{ "DENSITY", MtconnectUnit.MILLIGRAM_PER_CUBIC_MILLIMETER },

			{ "DEPOSITION_ACCELERATION_VOLUMETRIC", MtconnectUnit.CUBIC_MILLIMETER_PER_SECOND_SQUARED },

			{ "DEPOSITION_DENSITY", MtconnectUnit.MILLIGRAM_PER_CUBIC_MILLIMETER },

			{ "DEPOSITION_MASS", MtconnectUnit.MILLIGRAM },

			{ "DEPOSITION_RATE_VOLUMETRIC", MtconnectUnit.CUBIC_MILLIMETER_PER_SECOND },

			{ "DEPOSITION_VOLUME", MtconnectUnit.CUBIC_MILLIMETER },

			{ "DISPLACEMENT", MtconnectUnit.MILLIMETER },

			{ "ELECTRICAL_ENERGY", MtconnectUnit.WATT_SECOND },

			{ "EQUIPMENT_TIMER", MtconnectUnit.SECOND },

			{ "FILL_LEVEL", MtconnectUnit.PERCENT },

			{ "FLOW", MtconnectUnit.LITER_PER_SECOND },

			{ "FREQUENCY", MtconnectUnit.HERTZ },

			{ "GLOBAL_POSITION", MtconnectUnit.MILLIMETER },

			{ "LENGTH", MtconnectUnit.MILLIMETER },

			{ "LEVEL", MtconnectUnit.PERCENT },

			{ "LINEAR_FORCE", MtconnectUnit.NEWTON },

			{ "LOAD", MtconnectUnit.PERCENT },

			{ "MASS", MtconnectUnit.KILOGRAM },

			{ "PATH_FEEDRATE", MtconnectUnit.MILLIMETER_PER_SECOND },

			{ "PATH_FEEDRATE_PER_REVOLUTION", MtconnectUnit.MILLIMETER_PER_REVOLUTION },

			{ "PATH_POSITION", MtconnectUnit.MILLIMETER_3D },

			{ "PH", MtconnectUnit.PH },

			{ "POSITION", MtconnectUnit.MILLIMETER },

			{ "POWER_FACTOR", MtconnectUnit.PERCENT },

			{ "PRESSURE", MtconnectUnit.PASCAL },

			{ "PROCESS_TIMER", MtconnectUnit.SECOND },

			{ "RESISTANCE", MtconnectUnit.OHM },

			{ "ROTARY_VELOCITY", MtconnectUnit.REVOLUTION_PER_MINUTE },

			{ "SOUND_LEVEL", MtconnectUnit.DECIBEL },

			{ "SPINDLE_SPEED", MtconnectUnit.REVOLUTION_PER_MINUTE },

			{ "STRAIN", MtconnectUnit.PERCENT },

			{ "TEMPERATURE", MtconnectUnit.CELSIUS },

			{ "TENSION", MtconnectUnit.NEWTON },

			{ "TILT", MtconnectUnit.MICRO_RADIAN },

			{ "TORQUE", MtconnectUnit.NEWTON_METER },

			{ "VELOCITY", MtconnectUnit.MILLIMETER_PER_SECOND },

			{ "VISCOSITY", MtconnectUnit.PASCAL_SECOND },

			{ "VOLTAGE", MtconnectUnit.VOLT },

			{ "VOLT_AMPERE", MtconnectUnit.VOLT_AMPERE },

			{ "VOLT_AMPERE_REACTIVE", MtconnectUnit.VOLT_AMPERE_REACTIVE },

			{ "VOLUME_FLUID", MtconnectUnit.MILLILITER },

			{ "VOLUME_SPATIAL", MtconnectUnit.CUBIC_MILLIMETER },

			{ "WATTAGE", MtconnectUnit.WATT },

			{ "AMPERAGE_DC", MtconnectUnit.AMPERE },

			{ "AMPERAGE_AC", MtconnectUnit.AMPERE },

			{ "VOLTAGE_AC", MtconnectUnit.VOLT },

			{ "VOLTAGE_DC", MtconnectUnit.VOLT },

			{ "X_DIMENSION", MtconnectUnit.MILLIMETER },

			{ "Y_DIMENSION", MtconnectUnit.MILLIMETER },

			{ "Z_DIMENSION", MtconnectUnit.MILLIMETER },

			{ "DIAMETER", MtconnectUnit.MILLIMETER },

			{ "ORIENTATION", MtconnectUnit.DEGREE_3D },

			{ "HUMIDITY_RELATIVE", MtconnectUnit.PERCENT },

			{ "HUMIDITY_ABSOLUTE", MtconnectUnit.GRAM_PER_CUBIC_METER },

			{ "HUMIDITY_SPECIFIC", MtconnectUnit.PERCENT },

			{ "PRESSURIZATION_RATE", MtconnectUnit.PASCAL_PER_SECOND },

			{ "DECELERATION", MtconnectUnit.MILLIMETER_PER_SECOND_SQUARED },

			{ "ASSET_UPDATE_RATE", MtconnectUnit.COUNT_PER_SECOND },

			{ "ANGULAR_DECELERATION", MtconnectUnit.DEGREE_PER_SECOND_SQUARED },

			{ "OBSERVATION_UPDATE_RATE", MtconnectUnit.COUNT_PER_SECOND },

			{ "PRESSURE_ABSOLUTE", MtconnectUnit.PASCAL },

			{ "OPENNESS", MtconnectUnit.PERCENT },

			{ "DEW_POINT", MtconnectUnit.CELSIUS },

			{ "BATTERY_CAPACITY", MtconnectUnit.COULOMB },

			{ "DISCHARGE_RATE", MtconnectUnit.AMPERE },

			{ "CHARGE_RATE", MtconnectUnit.AMPERE },

			{ "BATTERY_CHARGE", MtconnectUnit.PERCENT },

			{ "SETTLING_ERROR", MtconnectUnit.COUNT },

			{ "SETTLING_ERROR_LINEAR", MtconnectUnit.MILLIMETER },

			{ "SETTLING_ERROR_ANGULAR", MtconnectUnit.DEGREE },

			{ "FOLLOWING_ERROR", MtconnectUnit.COUNT },

			{ "FOLLOWING_ERROR_ANGULAR", MtconnectUnit.DEGREE },

			{ "FOLLOWING_ERROR_LINEAR", MtconnectUnit.MILLIMETER },

			{ "DISPLACEMENT_LINEAR", MtconnectUnit.MILLIMETER },

			{ "DISPLACEMENT_ANGULAR", MtconnectUnit.DEGREE },

			{ "POSITION_CARTESIAN", MtconnectUnit.MILLIMETER_3D },

			{ "ROTATION", MtconnectUnit.DEGREE_3D },

			{ "TRANSLATION", MtconnectUnit.MILLIMETER_3D },
		};
		
		/// <summary>
		/// Stringifies the provided unit enum, attempting to convert it back into the string defined in the MTConnect Standard.
		/// </summary>
		public static string ToString(this MtconnectUnit unit)
			=> unit.ToString().Replace("_PER_", "/").Replace("_SQUARED", "^2").Replace("_CUBED", "^3");
	}
}