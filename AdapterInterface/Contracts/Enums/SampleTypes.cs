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
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		[ObservationalSubType(typeof(AccelerationSubTypes))]
		ACCELERATION,
		/// <summary>
		﻿/// {{def(SampleEnum:ACCUMULATED_TIME)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		ACCUMULATED_TIME,
		/// <summary>
		﻿/// {{def(SampleEnum:AMPERAGE)}}
		/// <br/><b>Sub-Type</b>: <see cref="AmperageSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		[ObservationalSubType(typeof(AmperageSubTypes))]
		AMPERAGE,
		/// <summary>
		﻿/// {{def(SampleEnum:ANGLE)}}
		/// <br/><b>Sub-Type</b>: <see cref="AngleSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		[ObservationalSubType(typeof(AngleSubTypes))]
		ANGLE,
		/// <summary>
		﻿/// {{def(SampleEnum:ANGULAR_ACCELERATION)}}
		/// <br/><b>Sub-Type</b>: <see cref="AngularAccelerationSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		[ObservationalSubType(typeof(AngularAccelerationSubTypes))]
		ANGULAR_ACCELERATION,
		/// <summary>
		﻿/// {{def(SampleEnum:ANGULAR_VELOCITY)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		ANGULAR_VELOCITY,
		/// <summary>
		﻿/// {{def(SampleEnum:AXIS_FEEDRATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="AxisFeedrateSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		[ObservationalSubType(typeof(AxisFeedrateSubTypes))]
		AXIS_FEEDRATE,
		/// <summary>
		﻿/// {{def(SampleEnum:CAPACITY_FLUID)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		CAPACITY_FLUID,
		/// <summary>
		﻿/// {{def(SampleEnum:CAPACITY_SPATIAL)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		CAPACITY_SPATIAL,
		/// <summary>
		﻿/// {{def(SampleEnum:CONCENTRATION)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		CONCENTRATION,
		/// <summary>
		﻿/// {{def(SampleEnum:CONDUCTIVITY)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		CONDUCTIVITY,
		/// <summary>
		﻿/// {{def(SampleEnum:CUTTING_SPEED)}}
		/// <br/><b>Sub-Type</b>: <see cref="CuttingSpeedSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalSubType(typeof(CuttingSpeedSubTypes))]
		CUTTING_SPEED,
		/// <summary>
		﻿/// {{def(SampleEnum:DENSITY)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		DENSITY,
		/// <summary>
		﻿/// {{def(SampleEnum:DEPOSITION_ACCELERATION_VOLUMETRIC)}}
		/// <br/><b>Sub-Type</b>: <see cref="DepositionAccelerationVolumetricSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalSubType(typeof(DepositionAccelerationVolumetricSubTypes))]
		DEPOSITION_ACCELERATION_VOLUMETRIC,
		/// <summary>
		﻿/// {{def(SampleEnum:DEPOSITION_DENSITY)}}
		/// <br/><b>Sub-Type</b>: <see cref="DepositionDensitySubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalSubType(typeof(DepositionDensitySubTypes))]
		DEPOSITION_DENSITY,
		/// <summary>
		﻿/// {{def(SampleEnum:DEPOSITION_MASS)}}
		/// <br/><b>Sub-Type</b>: <see cref="DepositionMassSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalSubType(typeof(DepositionMassSubTypes))]
		DEPOSITION_MASS,
		/// <summary>
		﻿/// {{def(SampleEnum:DEPOSITION_RATE_VOLUMETRIC)}}
		/// <br/><b>Sub-Type</b>: <see cref="DepositionRateVolumetricSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalSubType(typeof(DepositionRateVolumetricSubTypes))]
		DEPOSITION_RATE_VOLUMETRIC,
		/// <summary>
		﻿/// {{def(SampleEnum:DEPOSITION_VOLUME)}}
		/// <br/><b>Sub-Type</b>: <see cref="DepositionVolumeSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalSubType(typeof(DepositionVolumeSubTypes))]
		DEPOSITION_VOLUME,
		/// <summary>
		﻿/// {{def(SampleEnum:DISPLACEMENT)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		DISPLACEMENT,
		/// <summary>
		﻿/// {{def(SampleEnum:ELECTRICAL_ENERGY)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		ELECTRICAL_ENERGY,
		/// <summary>
		﻿/// {{def(SampleEnum:EQUIPMENT_TIMER)}}
		/// <br/><b>Sub-Type</b>: <see cref="EquipmentTimerSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		[ObservationalSubType(typeof(EquipmentTimerSubTypes))]
		EQUIPMENT_TIMER,
		/// <summary>
		﻿/// {{def(SampleEnum:FILL_LEVEL)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		FILL_LEVEL,
		/// <summary>
		﻿/// {{def(SampleEnum:FLOW)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		FLOW,
		/// <summary>
		﻿/// {{def(SampleEnum:FREQUENCY)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		FREQUENCY,
		/// <summary>
		﻿/// {{def(SampleEnum:GLOBAL_POSITION)}}
		/// <br/><b>Sub-Type</b>: <see cref="GlobalPositionSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		[ObservationalSubType(typeof(GlobalPositionSubTypes))]
		GLOBAL_POSITION,
		/// <summary>
		﻿/// {{def(SampleEnum:LENGTH)}}
		/// <br/><b>Sub-Type</b>: <see cref="LengthSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		[ObservationalSubType(typeof(LengthSubTypes))]
		LENGTH,
		/// <summary>
		﻿/// {{def(SampleEnum:LEVEL)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		LEVEL,
		/// <summary>
		﻿/// {{def(SampleEnum:LINEAR_FORCE)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		LINEAR_FORCE,
		/// <summary>
		﻿/// {{def(SampleEnum:LOAD)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		LOAD,
		/// <summary>
		﻿/// {{def(SampleEnum:MASS)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		MASS,
		/// <summary>
		﻿/// {{def(SampleEnum:PATH_FEEDRATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="PathFeedrateSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		[ObservationalSubType(typeof(PathFeedrateSubTypes))]
		PATH_FEEDRATE,
		/// <summary>
		﻿/// {{def(SampleEnum:PATH_FEEDRATE_PER_REVOLUTION)}}
		/// <br/><b>Sub-Type</b>: <see cref="PathFeedratePerRevolutionSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalSubType(typeof(PathFeedratePerRevolutionSubTypes))]
		PATH_FEEDRATE_PER_REVOLUTION,
		/// <summary>
		﻿/// {{def(SampleEnum:PATH_POSITION)}}
		/// <br/><b>Sub-Type</b>: <see cref="PathPositionSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		[ObservationalSubType(typeof(PathPositionSubTypes))]
		PATH_POSITION,
		/// <summary>
		﻿/// {{def(SampleEnum:PH)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		P_H,
		/// <summary>
		﻿/// {{def(SampleEnum:POSITION)}}
		/// <br/><b>Sub-Type</b>: <see cref="PositionSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		[ObservationalSubType(typeof(PositionSubTypes))]
		POSITION,
		/// <summary>
		﻿/// {{def(SampleEnum:POWER_FACTOR)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		POWER_FACTOR,
		/// <summary>
		﻿/// {{def(SampleEnum:PRESSURE)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		PRESSURE,
		/// <summary>
		﻿/// {{def(SampleEnum:PROCESS_TIMER)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProcessTimerSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		[ObservationalSubType(typeof(ProcessTimerSubTypes))]
		PROCESS_TIMER,
		/// <summary>
		﻿/// {{def(SampleEnum:RESISTANCE)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		RESISTANCE,
		/// <summary>
		﻿/// {{def(SampleEnum:ROTARY_VELOCITY)}}
		/// <br/><b>Sub-Type</b>: <see cref="RotaryVelocitySubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		[ObservationalSubType(typeof(RotaryVelocitySubTypes))]
		ROTARY_VELOCITY,
		/// <summary>
		﻿/// {{def(SampleEnum:SOUND_LEVEL)}}
		/// <br/><b>Sub-Type</b>: <see cref="SoundLevelSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		[ObservationalSubType(typeof(SoundLevelSubTypes))]
		SOUND_LEVEL,
		/// <summary>
		﻿/// {{def(SampleEnum:SPINDLE_SPEED)}}
		/// <br/><b>Sub-Type</b>: <see cref="SpindleSpeedSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		[ObservationalSubType(typeof(SpindleSpeedSubTypes))]
		SPINDLE_SPEED,
		/// <summary>
		﻿/// {{def(SampleEnum:STRAIN)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		STRAIN,
		/// <summary>
		﻿/// {{def(SampleEnum:TEMPERATURE)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		TEMPERATURE,
		/// <summary>
		﻿/// {{def(SampleEnum:TENSION)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		TENSION,
		/// <summary>
		﻿/// {{def(SampleEnum:TILT)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		TILT,
		/// <summary>
		﻿/// {{def(SampleEnum:TORQUE)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		TORQUE,
		/// <summary>
		﻿/// {{def(SampleEnum:VELOCITY)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		VELOCITY,
		/// <summary>
		﻿/// {{def(SampleEnum:VISCOSITY)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		VISCOSITY,
		/// <summary>
		﻿/// {{def(SampleEnum:VOLTAGE)}}
		/// <br/><b>Sub-Type</b>: <see cref="VoltageSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		[ObservationalSubType(typeof(VoltageSubTypes))]
		VOLTAGE,
		/// <summary>
		﻿/// {{def(SampleEnum:VOLT_AMPERE)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		VOLT_AMPERE,
		/// <summary>
		﻿/// {{def(SampleEnum:VOLT_AMPERE_REACTIVE)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		VOLT_AMPERE_REACTIVE,
		/// <summary>
		﻿/// {{def(SampleEnum:VOLUME_FLUID)}}
		/// <br/><b>Sub-Type</b>: <see cref="VolumeFluidSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalSubType(typeof(VolumeFluidSubTypes))]
		VOLUME_FLUID,
		/// <summary>
		﻿/// {{def(SampleEnum:VOLUME_SPATIAL)}}
		/// <br/><b>Sub-Type</b>: <see cref="VolumeSpatialSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalSubType(typeof(VolumeSpatialSubTypes))]
		VOLUME_SPATIAL,
		/// <summary>
		﻿/// {{def(SampleEnum:WATTAGE)}}
		/// <br/><b>Sub-Type</b>: <see cref="WattageSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		[ObservationalSubType(typeof(WattageSubTypes))]
		WATTAGE,
		/// <summary>
		﻿/// {{def(SampleEnum:AMPERAGE_DC)}}
		/// <br/><b>Sub-Type</b>: <see cref="AmperageDCSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[ObservationalSubType(typeof(AmperageDCSubTypes))]
		AMPERAGE_D_C,
		/// <summary>
		﻿/// {{def(SampleEnum:AMPERAGE_AC)}}
		/// <br/><b>Sub-Type</b>: <see cref="AmperageACSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[ObservationalSubType(typeof(AmperageACSubTypes))]
		AMPERAGE_A_C,
		/// <summary>
		﻿/// {{def(SampleEnum:VOLTAGE_AC)}}
		/// <br/><b>Sub-Type</b>: <see cref="VoltageACSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[ObservationalSubType(typeof(VoltageACSubTypes))]
		VOLTAGE_A_C,
		/// <summary>
		﻿/// {{def(SampleEnum:VOLTAGE_DC)}}
		/// <br/><b>Sub-Type</b>: <see cref="VoltageDCSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[ObservationalSubType(typeof(VoltageDCSubTypes))]
		VOLTAGE_D_C,
		/// <summary>
		﻿/// {{def(SampleEnum:X_DIMENSION)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		X_DIMENSION,
		/// <summary>
		﻿/// {{def(SampleEnum:Y_DIMENSION)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		Y_DIMENSION,
		/// <summary>
		﻿/// {{def(SampleEnum:Z_DIMENSION)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		Z_DIMENSION,
		/// <summary>
		﻿/// {{def(SampleEnum:DIAMETER)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		DIAMETER,
		/// <summary>
		﻿/// {{def(SampleEnum:ORIENTATION)}}
		/// <br/><b>Sub-Type</b>: <see cref="OrientationSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[ObservationalSubType(typeof(OrientationSubTypes))]
		ORIENTATION,
		/// <summary>
		﻿/// {{def(SampleEnum:HUMIDITY_RELATIVE)}}
		/// <br/><b>Sub-Type</b>: <see cref="HumidityRelativeSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[ObservationalSubType(typeof(HumidityRelativeSubTypes))]
		HUMIDITY_RELATIVE,
		/// <summary>
		﻿/// {{def(SampleEnum:HUMIDITY_ABSOLUTE)}}
		/// <br/><b>Sub-Type</b>: <see cref="HumidityAbsoluteSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[ObservationalSubType(typeof(HumidityAbsoluteSubTypes))]
		HUMIDITY_ABSOLUTE,
		/// <summary>
		﻿/// {{def(SampleEnum:HUMIDITY_SPECIFIC)}}
		/// <br/><b>Sub-Type</b>: <see cref="HumiditySpecificSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[ObservationalSubType(typeof(HumiditySpecificSubTypes))]
		HUMIDITY_SPECIFIC,
		/// <summary>
		﻿/// {{def(SampleEnum:PRESSURIZATION_RATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="PressurizationRateSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		[ObservationalSubType(typeof(PressurizationRateSubTypes))]
		PRESSURIZATION_RATE,
		/// <summary>
		﻿/// {{def(SampleEnum:DECELERATION)}}
		/// <br/><b>Sub-Type</b>: <see cref="DecelerationSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		[ObservationalSubType(typeof(DecelerationSubTypes))]
		DECELERATION,
		/// <summary>
		﻿/// {{def(SampleEnum:ASSET_UPDATE_RATE)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		ASSET_UPDATE_RATE,
		/// <summary>
		﻿/// {{def(SampleEnum:ANGULAR_DECELERATION)}}
		/// <br/><b>Sub-Type</b>: <see cref="AngularDecelerationSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		[ObservationalSubType(typeof(AngularDecelerationSubTypes))]
		ANGULAR_DECELERATION,
		/// <summary>
		﻿/// {{def(SampleEnum:OBSERVATION_UPDATE_RATE)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		OBSERVATION_UPDATE_RATE,
		/// <summary>
		﻿/// The force per unit area measured relative to a vacuum.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		PRESSURE_ABSOLUTE,
		/// <summary>
		﻿/// {{def(SampleEnum:OPENNESS)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see>.</remarks>
		OPENNESS,
		/// <summary>
		﻿/// {{def(SampleEnum:DEW_POINT)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		DEW_POINT,
		/// <summary>
		﻿/// {{def(SampleEnum:GRAVITATIONAL_FORCE)}}  > Note: $$<c>Mass</c> x <c>GravitationalAcceleration</c>$$
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		GRAVITATIONAL_FORCE,
		/// <summary>
		﻿/// {{def(SampleEnum:GRAVITATIONAL_ACCELERATION)}}  
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		GRAVITATIONAL_ACCELERATION,
		/// <summary>
		﻿/// {{def(SampleEnum:BATTERY_CAPACITY)}}
		/// <br/><b>Sub-Type</b>: <see cref="BatteryCapacitySubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		[ObservationalSubType(typeof(BatteryCapacitySubTypes))]
		BATTERY_CAPACITY,
		/// <summary>
		﻿/// {{def(SampleEnum:DISCHARGE_RATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="DischargeRateSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		[ObservationalSubType(typeof(DischargeRateSubTypes))]
		DISCHARGE_RATE,
		/// <summary>
		﻿/// {{def(SampleEnum:CHARGE_RATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="ChargeRateSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		[ObservationalSubType(typeof(ChargeRateSubTypes))]
		CHARGE_RATE,
		/// <summary>
		﻿/// {{def(SampleEnum:BATTERY_CHARGE)}}
		/// <br/><b>Sub-Type</b>: <see cref="BatteryChargeSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		[ObservationalSubType(typeof(BatteryChargeSubTypes))]
		BATTERY_CHARGE,
		/// <summary>
		﻿/// {{def(SampleEnum:SETTLING_ERROR)}}
		/// <br/><b>Sub-Type</b>: <see cref="SettlingErrorSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		[ObservationalSubType(typeof(SettlingErrorSubTypes))]
		SETTLING_ERROR,
		/// <summary>
		﻿/// {{def(SampleEnum:SETTLING_ERROR_LINEAR)}}
		/// <br/><b>Sub-Type</b>: <see cref="SettlingErrorLinearSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		[ObservationalSubType(typeof(SettlingErrorLinearSubTypes))]
		SETTLING_ERROR_LINEAR,
		/// <summary>
		﻿/// {{def(SampleEnum:SETTLING_ERROR_ANGULAR)}}
		/// <br/><b>Sub-Type</b>: <see cref="SettlingErrorAngularSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		[ObservationalSubType(typeof(SettlingErrorAngularSubTypes))]
		SETTLING_ERROR_ANGULAR,
		/// <summary>
		﻿/// {{def(SampleEnum:FOLLOWING_ERROR)}}
		/// <br/><b>Sub-Type</b>: <see cref="FollowingErrorSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		[ObservationalSubType(typeof(FollowingErrorSubTypes))]
		FOLLOWING_ERROR,
		/// <summary>
		﻿/// {{def(SampleEnum:FOLLOWING_ERROR_ANGULAR)}}
		/// <br/><b>Sub-Type</b>: <see cref="FollowingErrorAngularSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		[ObservationalSubType(typeof(FollowingErrorAngularSubTypes))]
		FOLLOWING_ERROR_ANGULAR,
		/// <summary>
		﻿/// {{def(SampleEnum:FOLLOWING_ERROR_LINEAR)}}
		/// <br/><b>Sub-Type</b>: <see cref="FollowingErrorLinearSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		[ObservationalSubType(typeof(FollowingErrorLinearSubTypes))]
		FOLLOWING_ERROR_LINEAR,
		/// <summary>
		﻿/// {{def(SampleEnum:DISPLACEMENT_LINEAR)}}  > Note: The displacement vector <b>MAY</b> be defined by the motion of the owning <see cref="component">component</see>.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		DISPLACEMENT_LINEAR,
		/// <summary>
		﻿/// {{def(SampleEnum:DISPLACEMENT_ANGULAR)}}  > Note: The displacement vector <b>MAY</b> be defined by the motion of the owning <see cref="component">component</see>.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		DISPLACEMENT_ANGULAR,
		/// <summary>
		﻿/// {{def(SampleEnum:POSITION_CARTESIAN)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		POSITION_CARTESIAN,
	}
}