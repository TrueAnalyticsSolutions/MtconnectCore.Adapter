#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum SampleTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// {{def(SampleEnum:ACCELERATION)}}
		/// <br/><b>Sub-Type</b>: <see cref="AccelerationSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(AccelerationSubTypes))]
		ACCELERATION,
		/// <summary>
		﻿/// {{def(SampleEnum:ACCUMULATED_TIME)}}
		/// </summary>
		ACCUMULATED_TIME,
		/// <summary>
		﻿/// {{def(SampleEnum:AMPERAGE)}}
		/// <br/><b>Sub-Type</b>: <see cref="AmperageSubTypes" />
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_6_0")]
		[ObservationalSubType(typeof(AmperageSubTypes))]
		AMPERAGE,
		/// <summary>
		﻿/// {{def(SampleEnum:ANGLE)}}
		/// <br/><b>Sub-Type</b>: <see cref="AngleSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(AngleSubTypes))]
		ANGLE,
		/// <summary>
		﻿/// {{def(SampleEnum:ANGULAR_ACCELERATION)}}
		/// <br/><b>Sub-Type</b>: <see cref="AngularAccelerationSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(AngularAccelerationSubTypes))]
		ANGULAR_ACCELERATION,
		/// <summary>
		﻿/// {{def(SampleEnum:ANGULAR_VELOCITY)}}
		/// </summary>
		ANGULAR_VELOCITY,
		/// <summary>
		﻿/// {{def(SampleEnum:AXIS_FEEDRATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="AxisFeedrateSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(AxisFeedrateSubTypes))]
		AXIS_FEEDRATE,
		/// <summary>
		﻿/// {{def(SampleEnum:CAPACITY_FLUID)}}
		/// </summary>
		CAPACITY_FLUID,
		/// <summary>
		﻿/// {{def(SampleEnum:CAPACITY_SPATIAL)}}
		/// </summary>
		CAPACITY_SPATIAL,
		/// <summary>
		﻿/// {{def(SampleEnum:CONCENTRATION)}}
		/// </summary>
		CONCENTRATION,
		/// <summary>
		﻿/// {{def(SampleEnum:CONDUCTIVITY)}}
		/// </summary>
		CONDUCTIVITY,
		/// <summary>
		﻿/// {{def(SampleEnum:CUTTING_SPEED)}}
		/// <br/><b>Sub-Type</b>: <see cref="CuttingSpeedSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(CuttingSpeedSubTypes))]
		CUTTING_SPEED,
		/// <summary>
		﻿/// {{def(SampleEnum:DENSITY)}}
		/// </summary>
		DENSITY,
		/// <summary>
		﻿/// {{def(SampleEnum:DEPOSITION_ACCELERATION_VOLUMETRIC)}}
		/// <br/><b>Sub-Type</b>: <see cref="DepositionAccelerationVolumetricSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(DepositionAccelerationVolumetricSubTypes))]
		DEPOSITION_ACCELERATION_VOLUMETRIC,
		/// <summary>
		﻿/// {{def(SampleEnum:DEPOSITION_DENSITY)}}
		/// <br/><b>Sub-Type</b>: <see cref="DepositionDensitySubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(DepositionDensitySubTypes))]
		DEPOSITION_DENSITY,
		/// <summary>
		﻿/// {{def(SampleEnum:DEPOSITION_MASS)}}
		/// <br/><b>Sub-Type</b>: <see cref="DepositionMassSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(DepositionMassSubTypes))]
		DEPOSITION_MASS,
		/// <summary>
		﻿/// {{def(SampleEnum:DEPOSITION_RATE_VOLUMETRIC)}}
		/// <br/><b>Sub-Type</b>: <see cref="DepositionRateVolumetricSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(DepositionRateVolumetricSubTypes))]
		DEPOSITION_RATE_VOLUMETRIC,
		/// <summary>
		﻿/// {{def(SampleEnum:DEPOSITION_VOLUME)}}
		/// <br/><b>Sub-Type</b>: <see cref="DepositionVolumeSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(DepositionVolumeSubTypes))]
		DEPOSITION_VOLUME,
		/// <summary>
		﻿/// {{def(SampleEnum:DISPLACEMENT)}}
		/// </summary>
		DISPLACEMENT,
		/// <summary>
		﻿/// {{def(SampleEnum:ELECTRICAL_ENERGY)}}
		/// </summary>
		ELECTRICAL_ENERGY,
		/// <summary>
		﻿/// {{def(SampleEnum:EQUIPMENT_TIMER)}}
		/// <br/><b>Sub-Type</b>: <see cref="EquipmentTimerSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(EquipmentTimerSubTypes))]
		EQUIPMENT_TIMER,
		/// <summary>
		﻿/// {{def(SampleEnum:FILL_LEVEL)}}
		/// </summary>
		FILL_LEVEL,
		/// <summary>
		﻿/// {{def(SampleEnum:FLOW)}}
		/// </summary>
		FLOW,
		/// <summary>
		﻿/// {{def(SampleEnum:FREQUENCY)}}
		/// </summary>
		FREQUENCY,
		/// <summary>
		﻿/// {{def(SampleEnum:GLOBAL_POSITION)}}
		/// <br/><b>Sub-Type</b>: <see cref="GlobalPositionSubTypes" />
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_1_0")]
		[ObservationalSubType(typeof(GlobalPositionSubTypes))]
		GLOBAL_POSITION,
		/// <summary>
		﻿/// {{def(SampleEnum:LENGTH)}}
		/// <br/><b>Sub-Type</b>: <see cref="LengthSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(LengthSubTypes))]
		LENGTH,
		/// <summary>
		﻿/// {{def(SampleEnum:LEVEL)}}
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_2_0")]
		LEVEL,
		/// <summary>
		﻿/// {{def(SampleEnum:LINEAR_FORCE)}}
		/// </summary>
		LINEAR_FORCE,
		/// <summary>
		﻿/// {{def(SampleEnum:LOAD)}}
		/// </summary>
		LOAD,
		/// <summary>
		﻿/// {{def(SampleEnum:MASS)}}
		/// </summary>
		MASS,
		/// <summary>
		﻿/// {{def(SampleEnum:PATH_FEEDRATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="PathFeedrateSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(PathFeedrateSubTypes))]
		PATH_FEEDRATE,
		/// <summary>
		﻿/// {{def(SampleEnum:PATH_FEEDRATE_PER_REVOLUTION)}}
		/// <br/><b>Sub-Type</b>: <see cref="PathFeedratePerRevolutionSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(PathFeedratePerRevolutionSubTypes))]
		PATH_FEEDRATE_PER_REVOLUTION,
		/// <summary>
		﻿/// {{def(SampleEnum:PATH_POSITION)}}
		/// <br/><b>Sub-Type</b>: <see cref="PathPositionSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(PathPositionSubTypes))]
		PATH_POSITION,
		/// <summary>
		﻿/// {{def(SampleEnum:PH)}}
		/// </summary>
		P_H,
		/// <summary>
		﻿/// {{def(SampleEnum:POSITION)}}
		/// <br/><b>Sub-Type</b>: <see cref="PositionSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(PositionSubTypes))]
		POSITION,
		/// <summary>
		﻿/// {{def(SampleEnum:POWER_FACTOR)}}
		/// </summary>
		POWER_FACTOR,
		/// <summary>
		﻿/// {{def(SampleEnum:PRESSURE)}}
		/// </summary>
		PRESSURE,
		/// <summary>
		﻿/// {{def(SampleEnum:PROCESS_TIMER)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProcessTimerSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(ProcessTimerSubTypes))]
		PROCESS_TIMER,
		/// <summary>
		﻿/// {{def(SampleEnum:RESISTANCE)}}
		/// </summary>
		RESISTANCE,
		/// <summary>
		﻿/// {{def(SampleEnum:ROTARY_VELOCITY)}}
		/// <br/><b>Sub-Type</b>: <see cref="RotaryVelocitySubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(RotaryVelocitySubTypes))]
		ROTARY_VELOCITY,
		/// <summary>
		﻿/// {{def(SampleEnum:SOUND_LEVEL)}}
		/// <br/><b>Sub-Type</b>: <see cref="SoundLevelSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(SoundLevelSubTypes))]
		SOUND_LEVEL,
		/// <summary>
		﻿/// {{def(SampleEnum:SPINDLE_SPEED)}}
		/// <br/><b>Sub-Type</b>: <see cref="SpindleSpeedSubTypes" />
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_2_0")]
		[ObservationalSubType(typeof(SpindleSpeedSubTypes))]
		SPINDLE_SPEED,
		/// <summary>
		﻿/// {{def(SampleEnum:STRAIN)}}
		/// </summary>
		STRAIN,
		/// <summary>
		﻿/// {{def(SampleEnum:TEMPERATURE)}}
		/// </summary>
		TEMPERATURE,
		/// <summary>
		﻿/// {{def(SampleEnum:TENSION)}}
		/// </summary>
		TENSION,
		/// <summary>
		﻿/// {{def(SampleEnum:TILT)}}
		/// </summary>
		TILT,
		/// <summary>
		﻿/// {{def(SampleEnum:TORQUE)}}
		/// </summary>
		TORQUE,
		/// <summary>
		﻿/// {{def(SampleEnum:VELOCITY)}}
		/// </summary>
		VELOCITY,
		/// <summary>
		﻿/// {{def(SampleEnum:VISCOSITY)}}
		/// </summary>
		VISCOSITY,
		/// <summary>
		﻿/// {{def(SampleEnum:VOLTAGE)}}
		/// <br/><b>Sub-Type</b>: <see cref="VoltageSubTypes" />
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_6_0")]
		[ObservationalSubType(typeof(VoltageSubTypes))]
		VOLTAGE,
		/// <summary>
		﻿/// {{def(SampleEnum:VOLT_AMPERE)}}
		/// </summary>
		VOLT_AMPERE,
		/// <summary>
		﻿/// {{def(SampleEnum:VOLT_AMPERE_REACTIVE)}}
		/// </summary>
		VOLT_AMPERE_REACTIVE,
		/// <summary>
		﻿/// {{def(SampleEnum:VOLUME_FLUID)}}
		/// <br/><b>Sub-Type</b>: <see cref="VolumeFluidSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(VolumeFluidSubTypes))]
		VOLUME_FLUID,
		/// <summary>
		﻿/// {{def(SampleEnum:VOLUME_SPATIAL)}}
		/// <br/><b>Sub-Type</b>: <see cref="VolumeSpatialSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(VolumeSpatialSubTypes))]
		VOLUME_SPATIAL,
		/// <summary>
		﻿/// {{def(SampleEnum:WATTAGE)}}
		/// <br/><b>Sub-Type</b>: <see cref="WattageSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(WattageSubTypes))]
		WATTAGE,
		/// <summary>
		﻿/// {{def(SampleEnum:AMPERAGE_DC)}}
		/// <br/><b>Sub-Type</b>: <see cref="AmperageDCSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(AmperageDCSubTypes))]
		AMPERAGE_D_C,
		/// <summary>
		﻿/// {{def(SampleEnum:AMPERAGE_AC)}}
		/// <br/><b>Sub-Type</b>: <see cref="AmperageACSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(AmperageACSubTypes))]
		AMPERAGE_A_C,
		/// <summary>
		﻿/// {{def(SampleEnum:VOLTAGE_AC)}}
		/// <br/><b>Sub-Type</b>: <see cref="VoltageACSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(VoltageACSubTypes))]
		VOLTAGE_A_C,
		/// <summary>
		﻿/// {{def(SampleEnum:VOLTAGE_DC)}}
		/// <br/><b>Sub-Type</b>: <see cref="VoltageDCSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(VoltageDCSubTypes))]
		VOLTAGE_D_C,
		/// <summary>
		﻿/// {{def(SampleEnum:X_DIMENSION)}}
		/// </summary>
		X_DIMENSION,
		/// <summary>
		﻿/// {{def(SampleEnum:Y_DIMENSION)}}
		/// </summary>
		Y_DIMENSION,
		/// <summary>
		﻿/// {{def(SampleEnum:Z_DIMENSION)}}
		/// </summary>
		Z_DIMENSION,
		/// <summary>
		﻿/// {{def(SampleEnum:DIAMETER)}}
		/// </summary>
		DIAMETER,
		/// <summary>
		﻿/// {{def(SampleEnum:ORIENTATION)}}
		/// <br/><b>Sub-Type</b>: <see cref="OrientationSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(OrientationSubTypes))]
		ORIENTATION,
		/// <summary>
		﻿/// {{def(SampleEnum:HUMIDITY_RELATIVE)}}
		/// <br/><b>Sub-Type</b>: <see cref="HumidityRelativeSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(HumidityRelativeSubTypes))]
		HUMIDITY_RELATIVE,
		/// <summary>
		﻿/// {{def(SampleEnum:HUMIDITY_ABSOLUTE)}}
		/// <br/><b>Sub-Type</b>: <see cref="HumidityAbsoluteSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(HumidityAbsoluteSubTypes))]
		HUMIDITY_ABSOLUTE,
		/// <summary>
		﻿/// {{def(SampleEnum:HUMIDITY_SPECIFIC)}}
		/// <br/><b>Sub-Type</b>: <see cref="HumiditySpecificSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(HumiditySpecificSubTypes))]
		HUMIDITY_SPECIFIC,
		/// <summary>
		﻿/// {{def(SampleEnum:PRESSURIZATION_RATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="PressurizationRateSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(PressurizationRateSubTypes))]
		PRESSURIZATION_RATE,
		/// <summary>
		﻿/// {{def(SampleEnum:DECELERATION)}}
		/// <br/><b>Sub-Type</b>: <see cref="DecelerationSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(DecelerationSubTypes))]
		DECELERATION,
		/// <summary>
		﻿/// {{def(SampleEnum:ASSET_UPDATE_RATE)}}
		/// </summary>
		ASSET_UPDATE_RATE,
		/// <summary>
		﻿/// {{def(SampleEnum:ANGULAR_DECELERATION)}}
		/// <br/><b>Sub-Type</b>: <see cref="AngularDecelerationSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(AngularDecelerationSubTypes))]
		ANGULAR_DECELERATION,
		/// <summary>
		﻿/// {{def(SampleEnum:OBSERVATION_UPDATE_RATE)}}
		/// </summary>
		OBSERVATION_UPDATE_RATE,
		/// <summary>
		﻿/// The force per unit area measured relative to a vacuum.
		/// </summary>
		PRESSURE_ABSOLUTE,
		/// <summary>
		﻿/// {{def(SampleEnum:OPENNESS)}}
		/// </summary>
		OPENNESS,
		/// <summary>
		﻿/// {{def(SampleEnum:DEW_POINT)}}
		/// </summary>
		DEW_POINT,
		/// <summary>
		﻿/// {{def(SampleEnum:GRAVITATIONAL_FORCE)}}  > Note: $$<c>Mass</c> x <c>GravitationalAcceleration</c>$$
		/// </summary>
		GRAVITATIONAL_FORCE,
		/// <summary>
		﻿/// {{def(SampleEnum:GRAVITATIONAL_ACCELERATION)}}  
		/// </summary>
		GRAVITATIONAL_ACCELERATION,
		/// <summary>
		﻿/// {{def(SampleEnum:BATTERY_CAPACITY)}}
		/// <br/><b>Sub-Type</b>: <see cref="BatteryCapacitySubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(BatteryCapacitySubTypes))]
		BATTERY_CAPACITY,
		/// <summary>
		﻿/// {{def(SampleEnum:DISCHARGE_RATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="DischargeRateSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(DischargeRateSubTypes))]
		DISCHARGE_RATE,
		/// <summary>
		﻿/// {{def(SampleEnum:CHARGE_RATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="ChargeRateSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(ChargeRateSubTypes))]
		CHARGE_RATE,
		/// <summary>
		﻿/// {{def(SampleEnum:BATTERY_CHARGE)}}
		/// <br/><b>Sub-Type</b>: <see cref="BatteryChargeSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(BatteryChargeSubTypes))]
		BATTERY_CHARGE,
		/// <summary>
		﻿/// {{def(SampleEnum:SETTLING_ERROR)}}
		/// <br/><b>Sub-Type</b>: <see cref="SettlingErrorSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(SettlingErrorSubTypes))]
		SETTLING_ERROR,
		/// <summary>
		﻿/// {{def(SampleEnum:SETTLING_ERROR_LINEAR)}}
		/// <br/><b>Sub-Type</b>: <see cref="SettlingErrorLinearSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(SettlingErrorLinearSubTypes))]
		SETTLING_ERROR_LINEAR,
		/// <summary>
		﻿/// {{def(SampleEnum:SETTLING_ERROR_ANGULAR)}}
		/// <br/><b>Sub-Type</b>: <see cref="SettlingErrorAngularSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(SettlingErrorAngularSubTypes))]
		SETTLING_ERROR_ANGULAR,
		/// <summary>
		﻿/// {{def(SampleEnum:FOLLOWING_ERROR)}}
		/// <br/><b>Sub-Type</b>: <see cref="FollowingErrorSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(FollowingErrorSubTypes))]
		FOLLOWING_ERROR,
		/// <summary>
		﻿/// {{def(SampleEnum:FOLLOWING_ERROR_ANGULAR)}}
		/// <br/><b>Sub-Type</b>: <see cref="FollowingErrorAngularSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(FollowingErrorAngularSubTypes))]
		FOLLOWING_ERROR_ANGULAR,
		/// <summary>
		﻿/// {{def(SampleEnum:FOLLOWING_ERROR_LINEAR)}}
		/// <br/><b>Sub-Type</b>: <see cref="FollowingErrorLinearSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(FollowingErrorLinearSubTypes))]
		FOLLOWING_ERROR_LINEAR,
		/// <summary>
		﻿/// {{def(SampleEnum:DISPLACEMENT_LINEAR)}}  > Note: The displacement vector <b>MAY</b> be defined by the motion of the owning <see cref="component">component</see>.
		/// </summary>
		DISPLACEMENT_LINEAR,
		/// <summary>
		﻿/// {{def(SampleEnum:DISPLACEMENT_ANGULAR)}}  > Note: The displacement vector <b>MAY</b> be defined by the motion of the owning <see cref="component">component</see>.
		/// </summary>
		DISPLACEMENT_ANGULAR,
		/// <summary>
		﻿/// {{def(SampleEnum:POSITION_CARTESIAN)}}
		/// </summary>
		POSITION_CARTESIAN,
	}
}