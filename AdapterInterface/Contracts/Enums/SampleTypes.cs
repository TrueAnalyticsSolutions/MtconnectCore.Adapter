#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580309868367_570061_44359">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.5.0")]
	public enum SampleTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// <see cref="SampleEnum.ACCELERATION />
		/// <br/><b>Sub-Type</b>: <see cref="AccelerationSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AccelerationSubTypes))]
		ACCELERATION,
		/// <summary>
		﻿/// <see cref="SampleEnum.ACCUMULATED_TIME />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ACCUMULATED_TIME,
		/// <summary>
		﻿/// <see cref="SampleEnum.AMPERAGE />
		/// <br/><b>Sub-Type</b>: <see cref="AmperageSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		[ObservationalSubType(typeof(AmperageSubTypes))]
		AMPERAGE,
		/// <summary>
		﻿/// <see cref="SampleEnum.ANGLE />
		/// <br/><b>Sub-Type</b>: <see cref="AngleSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AngleSubTypes))]
		ANGLE,
		/// <summary>
		﻿/// <see cref="SampleEnum.ANGULAR_ACCELERATION />
		/// <br/><b>Sub-Type</b>: <see cref="AngularAccelerationSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AngularAccelerationSubTypes))]
		ANGULAR_ACCELERATION,
		/// <summary>
		﻿/// <see cref="SampleEnum.ANGULAR_VELOCITY />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		ANGULAR_VELOCITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.AXIS_FEEDRATE />
		/// <br/><b>Sub-Type</b>: <see cref="AxisFeedrateSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AxisFeedrateSubTypes))]
		AXIS_FEEDRATE,
		/// <summary>
		﻿/// <see cref="SampleEnum.CAPACITY_FLUID />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		CAPACITY_FLUID,
		/// <summary>
		﻿/// <see cref="SampleEnum.CAPACITY_SPATIAL />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		CAPACITY_SPATIAL,
		/// <summary>
		﻿/// <see cref="SampleEnum.CONCENTRATION />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		CONCENTRATION,
		/// <summary>
		﻿/// <see cref="SampleEnum.CONDUCTIVITY />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		CONDUCTIVITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.CUTTING_SPEED />
		/// <br/><b>Sub-Type</b>: <see cref="CuttingSpeedSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(CuttingSpeedSubTypes))]
		CUTTING_SPEED,
		/// <summary>
		﻿/// <see cref="SampleEnum.DENSITY />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		DENSITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.DEPOSITION_ACCELERATION_VOLUMETRIC />
		/// <br/><b>Sub-Type</b>: <see cref="DepositionAccelerationVolumetricSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DepositionAccelerationVolumetricSubTypes))]
		DEPOSITION_ACCELERATION_VOLUMETRIC,
		/// <summary>
		﻿/// <see cref="SampleEnum.DEPOSITION_DENSITY />
		/// <br/><b>Sub-Type</b>: <see cref="DepositionDensitySubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DepositionDensitySubTypes))]
		DEPOSITION_DENSITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.DEPOSITION_MASS />
		/// <br/><b>Sub-Type</b>: <see cref="DepositionMassSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DepositionMassSubTypes))]
		DEPOSITION_MASS,
		/// <summary>
		﻿/// <see cref="SampleEnum.DEPOSITION_RATE_VOLUMETRIC />
		/// <br/><b>Sub-Type</b>: <see cref="DepositionRateVolumetricSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DepositionRateVolumetricSubTypes))]
		DEPOSITION_RATE_VOLUMETRIC,
		/// <summary>
		﻿/// <see cref="SampleEnum.DEPOSITION_VOLUME />
		/// <br/><b>Sub-Type</b>: <see cref="DepositionVolumeSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DepositionVolumeSubTypes))]
		DEPOSITION_VOLUME,
		/// <summary>
		﻿/// <see cref="SampleEnum.DISPLACEMENT />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		DISPLACEMENT,
		/// <summary>
		﻿/// <see cref="SampleEnum.ELECTRICAL_ENERGY />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ELECTRICAL_ENERGY,
		/// <summary>
		﻿/// <see cref="SampleEnum.EQUIPMENT_TIMER />
		/// <br/><b>Sub-Type</b>: <see cref="EquipmentTimerSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(EquipmentTimerSubTypes))]
		EQUIPMENT_TIMER,
		/// <summary>
		﻿/// <see cref="SampleEnum.FILL_LEVEL />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		FILL_LEVEL,
		/// <summary>
		﻿/// <see cref="SampleEnum.FLOW />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		FLOW,
		/// <summary>
		﻿/// <see cref="SampleEnum.FREQUENCY />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		FREQUENCY,
		/// <summary>
		﻿/// <see cref="SampleEnum.GLOBAL_POSITION />
		/// <br/><b>Sub-Type</b>: <see cref="GlobalPositionSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		[ObservationalSubType(typeof(GlobalPositionSubTypes))]
		GLOBAL_POSITION,
		/// <summary>
		﻿/// <see cref="SampleEnum.LENGTH />
		/// <br/><b>Sub-Type</b>: <see cref="LengthSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(LengthSubTypes))]
		LENGTH,
		/// <summary>
		﻿/// <see cref="SampleEnum.LEVEL />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		LEVEL,
		/// <summary>
		﻿/// <see cref="SampleEnum.LINEAR_FORCE />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		LINEAR_FORCE,
		/// <summary>
		﻿/// <see cref="SampleEnum.LOAD />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		LOAD,
		/// <summary>
		﻿/// <see cref="SampleEnum.MASS />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MASS,
		/// <summary>
		﻿/// <see cref="SampleEnum.PATH_FEEDRATE />
		/// <br/><b>Sub-Type</b>: <see cref="PathFeedrateSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PathFeedrateSubTypes))]
		PATH_FEEDRATE,
		/// <summary>
		﻿/// <see cref="SampleEnum.PATH_FEEDRATE_PER_REVOLUTION />
		/// <br/><b>Sub-Type</b>: <see cref="PathFeedratePerRevolutionSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PathFeedratePerRevolutionSubTypes))]
		PATH_FEEDRATE_PER_REVOLUTION,
		/// <summary>
		﻿/// <see cref="SampleEnum.PATH_POSITION />
		/// <br/><b>Sub-Type</b>: <see cref="PathPositionSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PathPositionSubTypes))]
		PATH_POSITION,
		/// <summary>
		﻿/// <see cref="SampleEnum.PH />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		P_H,
		/// <summary>
		﻿/// <see cref="SampleEnum.POSITION />
		/// <br/><b>Sub-Type</b>: <see cref="PositionSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PositionSubTypes))]
		POSITION,
		/// <summary>
		﻿/// <see cref="SampleEnum.POWER_FACTOR />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		POWER_FACTOR,
		/// <summary>
		﻿/// <see cref="SampleEnum.PRESSURE />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		PRESSURE,
		/// <summary>
		﻿/// <see cref="SampleEnum.PROCESS_TIMER />
		/// <br/><b>Sub-Type</b>: <see cref="ProcessTimerSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ProcessTimerSubTypes))]
		PROCESS_TIMER,
		/// <summary>
		﻿/// <see cref="SampleEnum.RESISTANCE />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		RESISTANCE,
		/// <summary>
		﻿/// <see cref="SampleEnum.ROTARY_VELOCITY />
		/// <br/><b>Sub-Type</b>: <see cref="RotaryVelocitySubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(RotaryVelocitySubTypes))]
		ROTARY_VELOCITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.SOUND_LEVEL />
		/// <br/><b>Sub-Type</b>: <see cref="SoundLevelSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(SoundLevelSubTypes))]
		SOUND_LEVEL,
		/// <summary>
		﻿/// <see cref="SampleEnum.SPINDLE_SPEED />
		/// <br/><b>Sub-Type</b>: <see cref="SpindleSpeedSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		[ObservationalSubType(typeof(SpindleSpeedSubTypes))]
		SPINDLE_SPEED,
		/// <summary>
		﻿/// <see cref="SampleEnum.STRAIN />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		STRAIN,
		/// <summary>
		﻿/// <see cref="SampleEnum.TEMPERATURE />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		TEMPERATURE,
		/// <summary>
		﻿/// <see cref="SampleEnum.TENSION />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		TENSION,
		/// <summary>
		﻿/// <see cref="SampleEnum.TILT />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		TILT,
		/// <summary>
		﻿/// <see cref="SampleEnum.TORQUE />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		TORQUE,
		/// <summary>
		﻿/// <see cref="SampleEnum.VELOCITY />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		VELOCITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.VISCOSITY />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		VISCOSITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.VOLTAGE />
		/// <br/><b>Sub-Type</b>: <see cref="VoltageSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		[ObservationalSubType(typeof(VoltageSubTypes))]
		VOLTAGE,
		/// <summary>
		﻿/// <see cref="SampleEnum.VOLT_AMPERE />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		VOLT_AMPERE,
		/// <summary>
		﻿/// <see cref="SampleEnum.VOLT_AMPERE_REACTIVE />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		VOLT_AMPERE_REACTIVE,
		/// <summary>
		﻿/// <see cref="SampleEnum.VOLUME_FLUID />
		/// <br/><b>Sub-Type</b>: <see cref="VolumeFluidSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(VolumeFluidSubTypes))]
		VOLUME_FLUID,
		/// <summary>
		﻿/// <see cref="SampleEnum.VOLUME_SPATIAL />
		/// <br/><b>Sub-Type</b>: <see cref="VolumeSpatialSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(VolumeSpatialSubTypes))]
		VOLUME_SPATIAL,
		/// <summary>
		﻿/// <see cref="SampleEnum.WATTAGE />
		/// <br/><b>Sub-Type</b>: <see cref="WattageSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(WattageSubTypes))]
		WATTAGE,
		/// <summary>
		﻿/// <see cref="SampleEnum.AMPERAGE_DC />
		/// <br/><b>Sub-Type</b>: <see cref="AmperageDCSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AmperageDCSubTypes))]
		AMPERAGE_D_C,
		/// <summary>
		﻿/// <see cref="SampleEnum.AMPERAGE_AC />
		/// <br/><b>Sub-Type</b>: <see cref="AmperageACSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AmperageACSubTypes))]
		AMPERAGE_A_C,
		/// <summary>
		﻿/// <see cref="SampleEnum.VOLTAGE_AC />
		/// <br/><b>Sub-Type</b>: <see cref="VoltageACSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(VoltageACSubTypes))]
		VOLTAGE_A_C,
		/// <summary>
		﻿/// <see cref="SampleEnum.VOLTAGE_DC />
		/// <br/><b>Sub-Type</b>: <see cref="VoltageDCSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(VoltageDCSubTypes))]
		VOLTAGE_D_C,
		/// <summary>
		﻿/// <see cref="SampleEnum.X_DIMENSION />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		X_DIMENSION,
		/// <summary>
		﻿/// <see cref="SampleEnum.Y_DIMENSION />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		Y_DIMENSION,
		/// <summary>
		﻿/// <see cref="SampleEnum.Z_DIMENSION />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		Z_DIMENSION,
		/// <summary>
		﻿/// <see cref="SampleEnum.DIAMETER />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		DIAMETER,
		/// <summary>
		﻿/// <see cref="SampleEnum.ORIENTATION />
		/// <br/><b>Sub-Type</b>: <see cref="OrientationSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(OrientationSubTypes))]
		ORIENTATION,
		/// <summary>
		﻿/// <see cref="SampleEnum.HUMIDITY_RELATIVE />
		/// <br/><b>Sub-Type</b>: <see cref="HumidityRelativeSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(HumidityRelativeSubTypes))]
		HUMIDITY_RELATIVE,
		/// <summary>
		﻿/// <see cref="SampleEnum.HUMIDITY_ABSOLUTE />
		/// <br/><b>Sub-Type</b>: <see cref="HumidityAbsoluteSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(HumidityAbsoluteSubTypes))]
		HUMIDITY_ABSOLUTE,
		/// <summary>
		﻿/// <see cref="SampleEnum.HUMIDITY_SPECIFIC />
		/// <br/><b>Sub-Type</b>: <see cref="HumiditySpecificSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(HumiditySpecificSubTypes))]
		HUMIDITY_SPECIFIC,
		/// <summary>
		﻿/// <see cref="SampleEnum.PRESSURIZATION_RATE />
		/// <br/><b>Sub-Type</b>: <see cref="PressurizationRateSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PressurizationRateSubTypes))]
		PRESSURIZATION_RATE,
		/// <summary>
		﻿/// <see cref="SampleEnum.DECELERATION />
		/// <br/><b>Sub-Type</b>: <see cref="DecelerationSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DecelerationSubTypes))]
		DECELERATION,
		/// <summary>
		﻿/// <see cref="SampleEnum.ASSET_UPDATE_RATE />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ASSET_UPDATE_RATE,
		/// <summary>
		﻿/// <see cref="SampleEnum.ANGULAR_DECELERATION />
		/// <br/><b>Sub-Type</b>: <see cref="AngularDecelerationSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AngularDecelerationSubTypes))]
		ANGULAR_DECELERATION,
		/// <summary>
		﻿/// <see cref="SampleEnum.OBSERVATION_UPDATE_RATE />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		OBSERVATION_UPDATE_RATE,
		/// <summary>
		﻿/// The force per unit area measured relative to a vacuum.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PRESSURE_ABSOLUTE,
		/// <summary>
		﻿/// <see cref="SampleEnum.OPENNESS />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		OPENNESS,
		/// <summary>
		﻿/// <see cref="SampleEnum.DEW_POINT />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		DEW_POINT,
		/// <summary>
		﻿/// <see cref="SampleEnum.GRAVITATIONAL_FORCE />  > Note: <i><c>Mass</c> x <c>GravitationalAcceleration</c></i>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		GRAVITATIONAL_FORCE,
		/// <summary>
		﻿/// <see cref="SampleEnum.GRAVITATIONAL_ACCELERATION />  
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		GRAVITATIONAL_ACCELERATION,
		/// <summary>
		﻿/// <see cref="SampleEnum.BATTERY_CAPACITY />
		/// <br/><b>Sub-Type</b>: <see cref="BatteryCapacitySubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(BatteryCapacitySubTypes))]
		BATTERY_CAPACITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.DISCHARGE_RATE />
		/// <br/><b>Sub-Type</b>: <see cref="DischargeRateSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DischargeRateSubTypes))]
		DISCHARGE_RATE,
		/// <summary>
		﻿/// <see cref="SampleEnum.CHARGE_RATE />
		/// <br/><b>Sub-Type</b>: <see cref="ChargeRateSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ChargeRateSubTypes))]
		CHARGE_RATE,
		/// <summary>
		﻿/// <see cref="SampleEnum.BATTERY_CHARGE />
		/// <br/><b>Sub-Type</b>: <see cref="BatteryChargeSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(BatteryChargeSubTypes))]
		BATTERY_CHARGE,
		/// <summary>
		﻿/// <see cref="SampleEnum.SETTLING_ERROR />
		/// <br/><b>Sub-Type</b>: <see cref="SettlingErrorSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(SettlingErrorSubTypes))]
		SETTLING_ERROR,
		/// <summary>
		﻿/// <see cref="SampleEnum.SETTLING_ERROR_LINEAR />
		/// <br/><b>Sub-Type</b>: <see cref="SettlingErrorLinearSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(SettlingErrorLinearSubTypes))]
		SETTLING_ERROR_LINEAR,
		/// <summary>
		﻿/// <see cref="SampleEnum.SETTLING_ERROR_ANGULAR />
		/// <br/><b>Sub-Type</b>: <see cref="SettlingErrorAngularSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(SettlingErrorAngularSubTypes))]
		SETTLING_ERROR_ANGULAR,
		/// <summary>
		﻿/// <see cref="SampleEnum.FOLLOWING_ERROR />
		/// <br/><b>Sub-Type</b>: <see cref="FollowingErrorSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(FollowingErrorSubTypes))]
		FOLLOWING_ERROR,
		/// <summary>
		﻿/// <see cref="SampleEnum.FOLLOWING_ERROR_ANGULAR />
		/// <br/><b>Sub-Type</b>: <see cref="FollowingErrorAngularSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(FollowingErrorAngularSubTypes))]
		FOLLOWING_ERROR_ANGULAR,
		/// <summary>
		﻿/// <see cref="SampleEnum.FOLLOWING_ERROR_LINEAR />
		/// <br/><b>Sub-Type</b>: <see cref="FollowingErrorLinearSubTypes" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(FollowingErrorLinearSubTypes))]
		FOLLOWING_ERROR_LINEAR,
		/// <summary>
		﻿/// <see cref="SampleEnum.DISPLACEMENT_LINEAR />  > Note: The displacement vector <b>MAY</b> be defined by the motion of the owning <see cref="component">component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		DISPLACEMENT_LINEAR,
		/// <summary>
		﻿/// <see cref="SampleEnum.DISPLACEMENT_ANGULAR />  > Note: The displacement vector <b>MAY</b> be defined by the motion of the owning <see cref="component">component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		DISPLACEMENT_ANGULAR,
		/// <summary>
		﻿/// <see cref="SampleEnum.POSITION_CARTESIAN />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		POSITION_CARTESIAN,
	}
}