#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.Contracts.Attributes;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580309868367_570061_44359">model.mtconnect.org</seealso>
	﻿	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public enum SampleTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// <see cref="SampleEnum.ACCELERATION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="AccelerationSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AccelerationSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		ACCELERATION,
		/// <summary>
		﻿/// <see cref="SampleEnum.ACCUMULATED_TIME" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		ACCUMULATED_TIME,
		/// <summary>
		﻿/// <see cref="SampleEnum.AMPERAGE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="AmperageSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		[ObservationalSubType(typeof(AmperageSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0", MtconnectVersions.V_1_6_0)]
		AMPERAGE,
		/// <summary>
		﻿/// <see cref="SampleEnum.ANGLE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="AngleSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AngleSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		ANGLE,
		/// <summary>
		﻿/// <see cref="SampleEnum.ANGULAR_ACCELERATION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="AngularAccelerationSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AngularAccelerationSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		ANGULAR_ACCELERATION,
		/// <summary>
		﻿/// <see cref="SampleEnum.ANGULAR_VELOCITY" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		ANGULAR_VELOCITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.AXIS_FEEDRATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="AxisFeedrateSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AxisFeedrateSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		AXIS_FEEDRATE,
		/// <summary>
		﻿/// <see cref="SampleEnum.CAPACITY_FLUID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		CAPACITY_FLUID,
		/// <summary>
		﻿/// <see cref="SampleEnum.CAPACITY_SPATIAL" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		CAPACITY_SPATIAL,
		/// <summary>
		﻿/// <see cref="SampleEnum.CONCENTRATION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		CONCENTRATION,
		/// <summary>
		﻿/// <see cref="SampleEnum.CONDUCTIVITY" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		CONDUCTIVITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.CUTTING_SPEED" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="CuttingSpeedSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(CuttingSpeedSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		CUTTING_SPEED,
		/// <summary>
		﻿/// <see cref="SampleEnum.DENSITY" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		DENSITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.DEPOSITION_ACCELERATION_VOLUMETRIC" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="DepositionAccelerationVolumetricSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DepositionAccelerationVolumetricSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		DEPOSITION_ACCELERATION_VOLUMETRIC,
		/// <summary>
		﻿/// <see cref="SampleEnum.DEPOSITION_DENSITY" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="DepositionDensitySubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DepositionDensitySubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		DEPOSITION_DENSITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.DEPOSITION_MASS" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="DepositionMassSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DepositionMassSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		DEPOSITION_MASS,
		/// <summary>
		﻿/// <see cref="SampleEnum.DEPOSITION_RATE_VOLUMETRIC" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="DepositionRateVolumetricSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DepositionRateVolumetricSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		DEPOSITION_RATE_VOLUMETRIC,
		/// <summary>
		﻿/// <see cref="SampleEnum.DEPOSITION_VOLUME" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="DepositionVolumeSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DepositionVolumeSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		DEPOSITION_VOLUME,
		/// <summary>
		﻿/// <see cref="SampleEnum.DISPLACEMENT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		DISPLACEMENT,
		/// <summary>
		﻿/// <see cref="SampleEnum.ELECTRICAL_ENERGY" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		ELECTRICAL_ENERGY,
		/// <summary>
		﻿/// <see cref="SampleEnum.EQUIPMENT_TIMER" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="EquipmentTimerSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(EquipmentTimerSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		EQUIPMENT_TIMER,
		/// <summary>
		﻿/// <see cref="SampleEnum.FILL_LEVEL" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		FILL_LEVEL,
		/// <summary>
		﻿/// <see cref="SampleEnum.FLOW" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		FLOW,
		/// <summary>
		﻿/// <see cref="SampleEnum.FREQUENCY" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		FREQUENCY,
		/// <summary>
		﻿/// <see cref="SampleEnum.GLOBAL_POSITION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="GlobalPositionSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		[ObservationalSubType(typeof(GlobalPositionSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0", MtconnectVersions.V_1_1_0)]
		GLOBAL_POSITION,
		/// <summary>
		﻿/// <see cref="SampleEnum.LENGTH" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="LengthSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(LengthSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		LENGTH,
		/// <summary>
		﻿/// <see cref="SampleEnum.LEVEL" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1", MtconnectVersions.V_1_2_0)]
		LEVEL,
		/// <summary>
		﻿/// <see cref="SampleEnum.LINEAR_FORCE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		LINEAR_FORCE,
		/// <summary>
		﻿/// <see cref="SampleEnum.LOAD" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		LOAD,
		/// <summary>
		﻿/// <see cref="SampleEnum.MASS" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		MASS,
		/// <summary>
		﻿/// <see cref="SampleEnum.PATH_FEEDRATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="PathFeedrateSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PathFeedrateSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		PATH_FEEDRATE,
		/// <summary>
		﻿/// <see cref="SampleEnum.PATH_FEEDRATE_PER_REVOLUTION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="PathFeedratePerRevolutionSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PathFeedratePerRevolutionSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		PATH_FEEDRATE_PER_REVOLUTION,
		/// <summary>
		﻿/// <see cref="SampleEnum.PATH_POSITION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="PathPositionSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PathPositionSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		PATH_POSITION,
		/// <summary>
		﻿/// <see cref="SampleEnum.PH" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		P_H,
		/// <summary>
		﻿/// <see cref="SampleEnum.POSITION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="PositionSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PositionSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		POSITION,
		/// <summary>
		﻿/// <see cref="SampleEnum.POWER_FACTOR" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		POWER_FACTOR,
		/// <summary>
		﻿/// <see cref="SampleEnum.PRESSURE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		PRESSURE,
		/// <summary>
		﻿/// <see cref="SampleEnum.PROCESS_TIMER" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ProcessTimerSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ProcessTimerSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		PROCESS_TIMER,
		/// <summary>
		﻿/// <see cref="SampleEnum.RESISTANCE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		RESISTANCE,
		/// <summary>
		﻿/// <see cref="SampleEnum.ROTARY_VELOCITY" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="RotaryVelocitySubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(RotaryVelocitySubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		ROTARY_VELOCITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.SOUND_LEVEL" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="SoundLevelSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(SoundLevelSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		SOUND_LEVEL,
		/// <summary>
		﻿/// <see cref="SampleEnum.SPINDLE_SPEED" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="SpindleSpeedSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		[ObservationalSubType(typeof(SpindleSpeedSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0", MtconnectVersions.V_1_2_0)]
		SPINDLE_SPEED,
		/// <summary>
		﻿/// <see cref="SampleEnum.STRAIN" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		STRAIN,
		/// <summary>
		﻿/// <see cref="SampleEnum.TEMPERATURE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		TEMPERATURE,
		/// <summary>
		﻿/// <see cref="SampleEnum.TENSION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		TENSION,
		/// <summary>
		﻿/// <see cref="SampleEnum.TILT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		TILT,
		/// <summary>
		﻿/// <see cref="SampleEnum.TORQUE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		TORQUE,
		/// <summary>
		﻿/// <see cref="SampleEnum.VELOCITY" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		VELOCITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.VISCOSITY" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		VISCOSITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.VOLTAGE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="VoltageSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		[ObservationalSubType(typeof(VoltageSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0", MtconnectVersions.V_1_6_0)]
		VOLTAGE,
		/// <summary>
		﻿/// <see cref="SampleEnum.VOLT_AMPERE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		VOLT_AMPERE,
		/// <summary>
		﻿/// <see cref="SampleEnum.VOLT_AMPERE_REACTIVE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		VOLT_AMPERE_REACTIVE,
		/// <summary>
		﻿/// <see cref="SampleEnum.VOLUME_FLUID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="VolumeFluidSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(VolumeFluidSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		VOLUME_FLUID,
		/// <summary>
		﻿/// <see cref="SampleEnum.VOLUME_SPATIAL" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="VolumeSpatialSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(VolumeSpatialSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		VOLUME_SPATIAL,
		/// <summary>
		﻿/// <see cref="SampleEnum.WATTAGE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="WattageSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(WattageSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		WATTAGE,
		/// <summary>
		﻿/// <see cref="SampleEnum.AMPERAGE_DC" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="AmperageDCSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AmperageDCSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		AMPERAGE_D_C,
		/// <summary>
		﻿/// <see cref="SampleEnum.AMPERAGE_AC" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="AmperageACSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AmperageACSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		AMPERAGE_A_C,
		/// <summary>
		﻿/// <see cref="SampleEnum.VOLTAGE_AC" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="VoltageACSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(VoltageACSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		VOLTAGE_A_C,
		/// <summary>
		﻿/// <see cref="SampleEnum.VOLTAGE_DC" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="VoltageDCSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(VoltageDCSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		VOLTAGE_D_C,
		/// <summary>
		﻿/// <see cref="SampleEnum.X_DIMENSION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		X_DIMENSION,
		/// <summary>
		﻿/// <see cref="SampleEnum.Y_DIMENSION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		Y_DIMENSION,
		/// <summary>
		﻿/// <see cref="SampleEnum.Z_DIMENSION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		Z_DIMENSION,
		/// <summary>
		﻿/// <see cref="SampleEnum.DIAMETER" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		DIAMETER,
		/// <summary>
		﻿/// <see cref="SampleEnum.ORIENTATION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="OrientationSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(OrientationSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		ORIENTATION,
		/// <summary>
		﻿/// <see cref="SampleEnum.HUMIDITY_RELATIVE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="HumidityRelativeSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(HumidityRelativeSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		HUMIDITY_RELATIVE,
		/// <summary>
		﻿/// <see cref="SampleEnum.HUMIDITY_ABSOLUTE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="HumidityAbsoluteSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(HumidityAbsoluteSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		HUMIDITY_ABSOLUTE,
		/// <summary>
		﻿/// <see cref="SampleEnum.HUMIDITY_SPECIFIC" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="HumiditySpecificSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(HumiditySpecificSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		HUMIDITY_SPECIFIC,
		/// <summary>
		﻿/// <see cref="SampleEnum.PRESSURIZATION_RATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="PressurizationRateSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PressurizationRateSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		PRESSURIZATION_RATE,
		/// <summary>
		﻿/// <see cref="SampleEnum.DECELERATION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="DecelerationSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DecelerationSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		DECELERATION,
		/// <summary>
		﻿/// <see cref="SampleEnum.ASSET_UPDATE_RATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		ASSET_UPDATE_RATE,
		/// <summary>
		﻿/// <see cref="SampleEnum.ANGULAR_DECELERATION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="AngularDecelerationSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AngularDecelerationSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		ANGULAR_DECELERATION,
		/// <summary>
		﻿/// <see cref="SampleEnum.OBSERVATION_UPDATE_RATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		OBSERVATION_UPDATE_RATE,
		/// <summary>
		﻿/// The force per unit area measured relative to a vacuum.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		PRESSURE_ABSOLUTE,
		/// <summary>
		﻿/// <see cref="SampleEnum.OPENNESS" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_0_0, "https://model.mtconnect.org/#_Version_2.0")]
		OPENNESS,
		/// <summary>
		﻿/// <see cref="SampleEnum.DEW_POINT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		DEW_POINT,
		/// <summary>
		﻿/// <see cref="SampleEnum.GRAVITATIONAL_FORCE" />  > Note: <i><c>Mass</c> x <c>GravitationalAcceleration</c></i>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		GRAVITATIONAL_FORCE,
		/// <summary>
		﻿/// <see cref="SampleEnum.GRAVITATIONAL_ACCELERATION" />  
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		GRAVITATIONAL_ACCELERATION,
		/// <summary>
		﻿/// <see cref="SampleEnum.BATTERY_CAPACITY" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="BatteryCapacitySubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(BatteryCapacitySubTypes))]
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		BATTERY_CAPACITY,
		/// <summary>
		﻿/// <see cref="SampleEnum.DISCHARGE_RATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="DischargeRateSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DischargeRateSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		DISCHARGE_RATE,
		/// <summary>
		﻿/// <see cref="SampleEnum.CHARGE_RATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ChargeRateSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ChargeRateSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		CHARGE_RATE,
		/// <summary>
		﻿/// <see cref="SampleEnum.BATTERY_CHARGE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="BatteryChargeSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(BatteryChargeSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		BATTERY_CHARGE,
		/// <summary>
		﻿/// <see cref="SampleEnum.SETTLING_ERROR" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="SettlingErrorSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(SettlingErrorSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		SETTLING_ERROR,
		/// <summary>
		﻿/// <see cref="SampleEnum.SETTLING_ERROR_LINEAR" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="SettlingErrorLinearSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(SettlingErrorLinearSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		SETTLING_ERROR_LINEAR,
		/// <summary>
		﻿/// <see cref="SampleEnum.SETTLING_ERROR_ANGULAR" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="SettlingErrorAngularSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(SettlingErrorAngularSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		SETTLING_ERROR_ANGULAR,
		/// <summary>
		﻿/// <see cref="SampleEnum.FOLLOWING_ERROR" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="FollowingErrorSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(FollowingErrorSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		FOLLOWING_ERROR,
		/// <summary>
		﻿/// <see cref="SampleEnum.FOLLOWING_ERROR_ANGULAR" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="FollowingErrorAngularSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(FollowingErrorAngularSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		FOLLOWING_ERROR_ANGULAR,
		/// <summary>
		﻿/// <see cref="SampleEnum.FOLLOWING_ERROR_LINEAR" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="FollowingErrorLinearSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(FollowingErrorLinearSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		FOLLOWING_ERROR_LINEAR,
		/// <summary>
		﻿/// <see cref="SampleEnum.DISPLACEMENT_LINEAR" />  > Note: The displacement vector <b>MAY</b> be defined by the motion of the owning <see cref="component">component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		DISPLACEMENT_LINEAR,
		/// <summary>
		﻿/// <see cref="SampleEnum.DISPLACEMENT_ANGULAR" />  > Note: The displacement vector <b>MAY</b> be defined by the motion of the owning <see cref="component">component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		DISPLACEMENT_ANGULAR,
		/// <summary>
		﻿/// <see cref="SampleEnum.POSITION_CARTESIAN" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		POSITION_CARTESIAN,
	}
}