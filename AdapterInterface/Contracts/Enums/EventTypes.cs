#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.DataItemValues;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580309852285_621670_44358">model.mtconnect.org</seealso>
	﻿	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.7.0")]
	public enum EventTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// <see cref="EventEnum.ACTIVE_AXES" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		ACTIVE_AXES,
		/// <summary>
		﻿/// <see cref="EventEnum.ACTUATOR_STATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="ActuatorStateValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ActuatorStateValues))]
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		ACTUATOR_STATE,
		/// <summary>
		﻿/// <see cref="EventEnum.ALARM" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0", MtconnectVersions.V_1_1_0)]
		ALARM,
		/// <summary>
		﻿/// <see cref="EventEnum.ASSET_CHANGED" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		ASSET_CHANGED,
		/// <summary>
		﻿/// <see cref="EventEnum.ASSET_REMOVED" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		ASSET_REMOVED,
		/// <summary>
		﻿/// <see cref="EventEnum.AVAILABILITY" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="AvailabilityValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(AvailabilityValues))]
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		AVAILABILITY,
		/// <summary>
		﻿/// <see cref="EventEnum.AXIS_COUPLING" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="AxisCouplingValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(AxisCouplingValues))]
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		AXIS_COUPLING,
		/// <summary>
		﻿/// <see cref="EventEnum.AXIS_FEEDRATE_OVERRIDE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="AxisFeedrateOverrideSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(AxisFeedrateOverrideSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		AXIS_FEEDRATE_OVERRIDE,
		/// <summary>
		﻿/// <see cref="EventEnum.AXIS_INTERLOCK" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="AxisInterlockValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(AxisInterlockValues))]
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		AXIS_INTERLOCK,
		/// <summary>
		﻿/// <see cref="EventEnum.AXIS_STATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="AxisStateValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(AxisStateValues))]
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		AXIS_STATE,
		/// <summary>
		﻿/// <see cref="EventEnum.BLOCK" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		BLOCK,
		/// <summary>
		﻿/// <see cref="EventEnum.BLOCK_COUNT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		BLOCK_COUNT,
		/// <summary>
		﻿/// <see cref="EventEnum.CHUCK_INTERLOCK" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ChuckInterlockSubTypes" /></item>
		/// <item><b>Values</b>: <see cref="ChuckInterlockValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ChuckInterlockSubTypes))]
		[ObservationalValue(typeof(ChuckInterlockValues))]
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		CHUCK_INTERLOCK,
		/// <summary>
		﻿/// <see cref="EventEnum.CHUCK_STATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="ChuckStateValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ChuckStateValues))]
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		CHUCK_STATE,
		/// <summary>
		﻿/// <see cref="EventEnum.CODE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0", MtconnectVersions.V_1_1_0)]
		CODE,
		/// <summary>
		﻿/// <see cref="EventEnum.COMPOSITION_STATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="CompositionStateSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(CompositionStateSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		COMPOSITION_STATE,
		/// <summary>
		﻿/// <see cref="EventEnum.CONTROLLER_MODE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="ControllerModeValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ControllerModeValues))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		CONTROLLER_MODE,
		/// <summary>
		﻿/// <see cref="EventEnum.CONTROLLER_MODE_OVERRIDE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ControllerModeOverrideSubTypes" /></item>
		/// <item><b>Values</b>: <see cref="ControllerModeOverrideValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ControllerModeOverrideSubTypes))]
		[ObservationalValue(typeof(ControllerModeOverrideValues))]
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		CONTROLLER_MODE_OVERRIDE,
		/// <summary>
		﻿/// <see cref="EventEnum.COUPLED_AXES" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		COUPLED_AXES,
		/// <summary>
		﻿/// <see cref="EventEnum.DATE_CODE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="DateCodeSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DateCodeSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		DATE_CODE,
		/// <summary>
		﻿/// <see cref="EventEnum.DEVICE_UUID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		DEVICE_UUID,
		/// <summary>
		﻿/// <see cref="EventEnum.DIRECTION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="DirectionSubTypes" /></item>
		/// <item><b>Values</b>: <see cref="DirectionValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DirectionSubTypes))]
		[ObservationalValue(typeof(DirectionValues))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		DIRECTION,
		/// <summary>
		﻿/// <see cref="EventEnum.DOOR_STATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="DoorStateValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(DoorStateValues))]
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		DOOR_STATE,
		/// <summary>
		﻿/// <see cref="EventEnum.EMERGENCY_STOP" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="EmergencyStopValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(EmergencyStopValues))]
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		EMERGENCY_STOP,
		/// <summary>
		﻿/// <see cref="EventEnum.END_OF_BAR" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="EndOfBarSubTypes" /></item>
		/// <item><b>Values</b>: <see cref="EndOfBarValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(EndOfBarSubTypes))]
		[ObservationalValue(typeof(EndOfBarValues))]
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		END_OF_BAR,
		/// <summary>
		﻿/// <see cref="EventEnum.EQUIPMENT_MODE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="EquipmentModeSubTypes" /></item>
		/// <item><b>Values</b>: <see cref="EquipmentModeValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(EquipmentModeSubTypes))]
		[ObservationalValue(typeof(EquipmentModeValues))]
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		EQUIPMENT_MODE,
		/// <summary>
		﻿/// <see cref="EventEnum.EXECUTION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="ExecutionValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ExecutionValues))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		EXECUTION,
		/// <summary>
		﻿/// <see cref="EventEnum.FUNCTIONAL_MODE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="FunctionalModeValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(FunctionalModeValues))]
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		FUNCTIONAL_MODE,
		/// <summary>
		﻿/// <see cref="EventEnum.HARDNESS" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="HardnessSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(HardnessSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		HARDNESS,
		/// <summary>
		﻿/// <see cref="EventEnum.LINE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="LineSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
		[ObservationalSubType(typeof(LineSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0", MtconnectVersions.V_1_4_0)]
		LINE,
		/// <summary>
		﻿/// <see cref="EventEnum.LINE_LABEL" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		LINE_LABEL,
		/// <summary>
		﻿/// <see cref="EventEnum.LINE_NUMBER" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="LineNumberSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(LineNumberSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		LINE_NUMBER,
		/// <summary>
		﻿/// <see cref="EventEnum.MATERIAL" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		MATERIAL,
		/// <summary>
		﻿/// <see cref="EventEnum.MATERIAL_LAYER" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="MaterialLayerSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(MaterialLayerSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		MATERIAL_LAYER,
		/// <summary>
		﻿/// <see cref="EventEnum.MESSAGE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		MESSAGE,
		/// <summary>
		﻿/// <see cref="EventEnum.OPERATOR_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		OPERATOR_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.PALLET_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		PALLET_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.PART_COUNT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="PartCountSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PartCountSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		PART_COUNT,
		/// <summary>
		﻿/// <see cref="EventEnum.PART_DETECT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="PartDetectValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(PartDetectValues))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		PART_DETECT,
		/// <summary>
		﻿/// <see cref="EventEnum.PART_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		PART_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.PART_NUMBER" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.7 according to https://model.mtconnect.org/#_Version_1.7")]
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4", MtconnectVersions.V_1_7_0)]
		PART_NUMBER,
		/// <summary>
		﻿/// <see cref="EventEnum.PATH_FEEDRATE_OVERRIDE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="PathFeedrateOverrideSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PathFeedrateOverrideSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		PATH_FEEDRATE_OVERRIDE,
		/// <summary>
		﻿/// <see cref="EventEnum.PATH_MODE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="PathModeValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(PathModeValues))]
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		PATH_MODE,
		/// <summary>
		﻿/// <see cref="EventEnum.POWER_STATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="PowerStateSubTypes" /></item>
		/// <item><b>Values</b>: <see cref="PowerStateValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PowerStateSubTypes))]
		[ObservationalValue(typeof(PowerStateValues))]
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		POWER_STATE,
		/// <summary>
		﻿/// <see cref="EventEnum.POWER_STATUS" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="PowerStatusValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		[ObservationalValue(typeof(PowerStatusValues))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0", MtconnectVersions.V_1_1_0)]
		POWER_STATUS,
		/// <summary>
		﻿/// <see cref="EventEnum.PROCESS_TIME" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ProcessTimeSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ProcessTimeSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		PROCESS_TIME,
		/// <summary>
		﻿/// <see cref="EventEnum.PROGRAM" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ProgramSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ProgramSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		PROGRAM,
		/// <summary>
		﻿/// <see cref="EventEnum.PROGRAM_COMMENT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ProgramCommentSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ProgramCommentSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		PROGRAM_COMMENT,
		/// <summary>
		﻿/// <see cref="EventEnum.PROGRAM_EDIT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="ProgramEditValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ProgramEditValues))]
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		PROGRAM_EDIT,
		/// <summary>
		﻿/// <see cref="EventEnum.PROGRAM_EDIT_NAME" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		PROGRAM_EDIT_NAME,
		/// <summary>
		﻿/// <see cref="EventEnum.PROGRAM_HEADER" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ProgramHeaderSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ProgramHeaderSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		PROGRAM_HEADER,
		/// <summary>
		﻿/// <see cref="EventEnum.PROGRAM_LOCATION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ProgramLocationSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ProgramLocationSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		PROGRAM_LOCATION,
		/// <summary>
		﻿/// <see cref="EventEnum.PROGRAM_LOCATION_TYPE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ProgramLocationTypeSubTypes" /></item>
		/// <item><b>Values</b>: <see cref="ProgramLocationTypeValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ProgramLocationTypeSubTypes))]
		[ObservationalValue(typeof(ProgramLocationTypeValues))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		PROGRAM_LOCATION_TYPE,
		/// <summary>
		﻿/// <see cref="EventEnum.PROGRAM_NEST_LEVEL" />  If an initial value is not defined, the nesting level associated with the highest or initial nesting level of the program <b>MUST</b> default to zero (0). 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		PROGRAM_NEST_LEVEL,
		/// <summary>
		﻿/// <see cref="EventEnum.ROTARY_MODE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="RotaryModeValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(RotaryModeValues))]
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		ROTARY_MODE,
		/// <summary>
		﻿/// <see cref="EventEnum.ROTARY_VELOCITY_OVERRIDE" />  This command represents a percentage change to the velocity calculated by a logic or motion program or set by a switch for a <see cref="Rotary">Rotary</see> type axis.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		ROTARY_VELOCITY_OVERRIDE,
		/// <summary>
		﻿/// <see cref="EventEnum.SERIAL_NUMBER" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		SERIAL_NUMBER,
		/// <summary>
		﻿/// <see cref="EventEnum.SPINDLE_INTERLOCK" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="SpindleInterlockValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(SpindleInterlockValues))]
		[MtconnectVersion(MtconnectVersions.V_1_3_0, "https://model.mtconnect.org/#_Version_1.3")]
		SPINDLE_INTERLOCK,
		/// <summary>
		﻿/// <see cref="EventEnum.TOOL_ASSET_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		TOOL_ASSET_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.TOOL_GROUP" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		TOOL_GROUP,
		/// <summary>
		﻿/// <see cref="EventEnum.TOOL_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1", MtconnectVersions.V_1_2_0)]
		TOOL_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.TOOL_NUMBER" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		TOOL_NUMBER,
		/// <summary>
		﻿/// <see cref="EventEnum.TOOL_OFFSET" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ToolOffsetSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ToolOffsetSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		TOOL_OFFSET,
		/// <summary>
		﻿/// <see cref="EventEnum.USER" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="UserSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(UserSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		USER,
		/// <summary>
		﻿/// <see cref="EventEnum.VARIABLE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		VARIABLE,
		/// <summary>
		﻿/// <see cref="EventEnum.WAIT_STATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="WaitStateValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(WaitStateValues))]
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		WAIT_STATE,
		/// <summary>
		﻿/// <see cref="EventEnum.WIRE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		WIRE,
		/// <summary>
		﻿/// <see cref="EventEnum.WORKHOLDING_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		WORKHOLDING_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.WORK_OFFSET" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		WORK_OFFSET,
		/// <summary>
		﻿/// <see cref="EventEnum.OPERATING_SYSTEM" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="OperatingSystemSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(OperatingSystemSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		OPERATING_SYSTEM,
		/// <summary>
		﻿/// <see cref="EventEnum.FIRMWARE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="FirmwareSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(FirmwareSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		FIRMWARE,
		/// <summary>
		﻿/// <see cref="EventEnum.APPLICATION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ApplicationSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ApplicationSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		APPLICATION,
		/// <summary>
		﻿/// <see cref="EventEnum.LIBRARY" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="LibrarySubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(LibrarySubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		LIBRARY,
		/// <summary>
		﻿/// <see cref="EventEnum.HARDWARE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="HardwareSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(HardwareSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_4_0, "https://model.mtconnect.org/#_Version_1.4")]
		HARDWARE,
		/// <summary>
		﻿/// <see cref="EventEnum.NETWORK" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="NetworkSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(NetworkSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		NETWORK,
		/// <summary>
		﻿/// <see cref="EventEnum.ROTATION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		ROTATION,
		/// <summary>
		﻿/// <see cref="EventEnum.TRANSLATION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		TRANSLATION,
		/// <summary>
		﻿/// <see cref="EventEnum.PROCESS_KIND_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ProcessKindIdSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ProcessKindIdSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		PROCESS_KIND_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.PART_STATUS" />  If unique identifier is given, part status is for that individual. If group identifier is given without a unique identifier, then the status is assumed to be for the whole group.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="PartStatusValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(PartStatusValues))]
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		PART_STATUS,
		/// <summary>
		﻿/// <see cref="EventEnum.ALARM_LIMIT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		ALARM_LIMIT,
		/// <summary>
		﻿/// <see cref="EventEnum.PROCESS_AGGREGATE_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ProcessAggregateIdSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ProcessAggregateIdSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		PROCESS_AGGREGATE_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.PART_KIND_ID" />  If no <see cref="subType" /> is specified, <c>UUID</c> is default. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="PartKindIdSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PartKindIdSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		PART_KIND_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.ADAPTER_URI" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		ADAPTER_U_R_I,
		/// <summary>
		﻿/// <see cref="EventEnum.DEVICE_REMOVED" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		DEVICE_REMOVED,
		/// <summary>
		﻿/// <see cref="EventEnum.DEVICE_CHANGED" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		DEVICE_CHANGED,
		/// <summary>
		﻿/// <see cref="EventEnum.SPECIFICATION_LIMIT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		SPECIFICATION_LIMIT,
		/// <summary>
		﻿/// <see cref="EventEnum.CONNECTION_STATUS" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="ConnectionStatusValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ConnectionStatusValues))]
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		CONNECTION_STATUS,
		/// <summary>
		﻿/// <see cref="EventEnum.ADAPTER_SOFTWARE_VERSION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		ADAPTER_SOFTWARE_VERSION,
		/// <summary>
		﻿/// <see cref="EventEnum.SENSOR_ATTACHMENT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		SENSOR_ATTACHMENT,
		/// <summary>
		﻿/// <see cref="EventEnum.CONTROL_LIMIT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		CONTROL_LIMIT,
		/// <summary>
		﻿/// <see cref="EventEnum.DEVICE_ADDED" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		DEVICE_ADDED,
		/// <summary>
		﻿/// <see cref="EventEnum.MTCONNECT_VERSION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		M_T_CONNECT_VERSION,
		/// <summary>
		﻿/// <see cref="EventEnum.PROCESS_OCCURRENCE_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ProcessOccurrenceIdSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ProcessOccurrenceIdSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		PROCESS_OCCURRENCE_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.PART_GROUP_ID" />  If no <see cref="subType" /> is specified, <c>UUID</c> is default.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="PartGroupIdSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PartGroupIdSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		PART_GROUP_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.PART_UNIQUE_ID" />  If no <see cref="subType" /> is specified, <c>UUID</c> is default. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="PartUniqueIdSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(PartUniqueIdSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		PART_UNIQUE_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.ACTIVATION_COUNT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ActivationCountSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ActivationCountSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_8_0, "https://model.mtconnect.org/#_Version_1.8")]
		ACTIVATION_COUNT,
		/// <summary>
		﻿/// <see cref="EventEnum.DEACTIVATION_COUNT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="DeactivationCountSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(DeactivationCountSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_8_0, "https://model.mtconnect.org/#_Version_1.8")]
		DEACTIVATION_COUNT,
		/// <summary>
		﻿/// <see cref="EventEnum.TRANSFER_COUNT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="TransferCountSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(TransferCountSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_8_0, "https://model.mtconnect.org/#_Version_1.8")]
		TRANSFER_COUNT,
		/// <summary>
		﻿/// <see cref="EventEnum.LOAD_COUNT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="LoadCountSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(LoadCountSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_8_0, "https://model.mtconnect.org/#_Version_1.8")]
		LOAD_COUNT,
		/// <summary>
		﻿/// <see cref="EventEnum.PART_PROCESSING_STATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="PartProcessingStateValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(PartProcessingStateValues))]
		[MtconnectVersion(MtconnectVersions.V_1_8_0, "https://model.mtconnect.org/#_Version_1.8")]
		PART_PROCESSING_STATE,
		/// <summary>
		﻿/// <see cref="EventEnum.PROCESS_STATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="ProcessStateValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(ProcessStateValues))]
		[MtconnectVersion(MtconnectVersions.V_1_8_0, "https://model.mtconnect.org/#_Version_1.8")]
		PROCESS_STATE,
		/// <summary>
		﻿/// <see cref="EventEnum.VALVE_STATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="ValveStateSubTypes" /></item>
		/// <item><b>Values</b>: <see cref="ValveStateValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(ValveStateSubTypes))]
		[ObservationalValue(typeof(ValveStateValues))]
		[MtconnectVersion(MtconnectVersions.V_1_8_0, "https://model.mtconnect.org/#_Version_1.8")]
		VALVE_STATE,
		/// <summary>
		﻿/// <see cref="EventEnum.LOCK_STATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="LockStateValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(LockStateValues))]
		[MtconnectVersion(MtconnectVersions.V_1_8_0, "https://model.mtconnect.org/#_Version_1.8")]
		LOCK_STATE,
		/// <summary>
		﻿/// <see cref="EventEnum.UNLOAD_COUNT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="UnloadCountSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(UnloadCountSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_8_0, "https://model.mtconnect.org/#_Version_1.8")]
		UNLOAD_COUNT,
		/// <summary>
		﻿/// <see cref="EventEnum.CYCLE_COUNT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Sub-Type</b>: <see cref="CycleCountSubTypes" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		[ObservationalSubType(typeof(CycleCountSubTypes))]
		[MtconnectVersion(MtconnectVersions.V_1_8_0, "https://model.mtconnect.org/#_Version_1.8")]
		CYCLE_COUNT,
		/// <summary>
		﻿/// <see cref="EventEnum.OPERATING_MODE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="OperatingModeValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(OperatingModeValues))]
		[MtconnectVersion(MtconnectVersions.V_2_0_0, "https://model.mtconnect.org/#_Version_2.0")]
		OPERATING_MODE,
		/// <summary>
		﻿/// <see cref="EventEnum.ASSET_COUNT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_0_0, "https://model.mtconnect.org/#_Version_2.0")]
		ASSET_COUNT,
		/// <summary>
		﻿/// <see cref="EventEnum.MAINTENANCE_LIST" />  If the <see cref="INTERVAL" /> <see cref="key" /> is not provided, it is assumed <c>ABSOLUTE</c>.  If the <see cref="DIRECTION" /> <see cref="key" /> is not provided, it is assumed <c>UP</c>.  If the <see cref="UNITS" /> <see cref="key" /> is not provided, it is assumed to be <c>COUNT</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_0_0, "https://model.mtconnect.org/#_Version_2.0")]
		MAINTENANCE_LIST,
		/// <summary>
		﻿/// <see cref="EventEnum.FIXTURE_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_0_0, "https://model.mtconnect.org/#_Version_2.0")]
		FIXTURE_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.PART_COUNT_TYPE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="PartCountTypeValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(PartCountTypeValues))]
		[MtconnectVersion(MtconnectVersions.V_2_0_0, "https://model.mtconnect.org/#_Version_2.0")]
		PART_COUNT_TYPE,
		/// <summary>
		﻿/// <see cref="EventEnum.CLOCK_TIME" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		CLOCK_TIME,
		/// <summary>
		﻿/// <see cref="EventEnum.NETWORK_PORT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		NETWORK_PORT,
		/// <summary>
		﻿/// <see cref="EventEnum.HOST_NAME" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		HOST_NAME,
		/// <summary>
		﻿/// <see cref="EventEnum.LEAK_DETECT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="LeakDetectValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(LeakDetectValues))]
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		LEAK_DETECT,
		/// <summary>
		﻿/// <see cref="EventEnum.BATTERY_STATE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Values</b>: <see cref="BatteryStateValues" /></item>
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[ObservationalValue(typeof(BatteryStateValues))]
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		BATTERY_STATE,
	}
}