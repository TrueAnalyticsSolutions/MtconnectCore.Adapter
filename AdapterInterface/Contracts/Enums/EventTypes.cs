#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
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
		ALARM,
		/// <summary>
		﻿/// <see cref="EventEnum.ASSET_CHANGED" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ASSET_CHANGED,
		/// <summary>
		﻿/// <see cref="EventEnum.ASSET_REMOVED" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
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
		AXIS_STATE,
		/// <summary>
		﻿/// <see cref="EventEnum.BLOCK" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		BLOCK,
		/// <summary>
		﻿/// <see cref="EventEnum.BLOCK_COUNT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
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
		CONTROLLER_MODE_OVERRIDE,
		/// <summary>
		﻿/// <see cref="EventEnum.COUPLED_AXES" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
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
		DATE_CODE,
		/// <summary>
		﻿/// <see cref="EventEnum.DEVICE_UUID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
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
		LINE,
		/// <summary>
		﻿/// <see cref="EventEnum.LINE_LABEL" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
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
		LINE_NUMBER,
		/// <summary>
		﻿/// <see cref="EventEnum.MATERIAL" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
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
		MATERIAL_LAYER,
		/// <summary>
		﻿/// <see cref="EventEnum.MESSAGE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		MESSAGE,
		/// <summary>
		﻿/// <see cref="EventEnum.OPERATOR_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		OPERATOR_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.PALLET_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
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
		PART_DETECT,
		/// <summary>
		﻿/// <see cref="EventEnum.PART_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
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
		PROGRAM_EDIT,
		/// <summary>
		﻿/// <see cref="EventEnum.PROGRAM_EDIT_NAME" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
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
		PROGRAM_LOCATION_TYPE,
		/// <summary>
		﻿/// <see cref="EventEnum.PROGRAM_NEST_LEVEL" />  If an initial value is not defined, the nesting level associated with the highest or initial nesting level of the program <b>MUST</b> default to zero (0). 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
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
		ROTARY_MODE,
		/// <summary>
		﻿/// <see cref="EventEnum.ROTARY_VELOCITY_OVERRIDE" />  This command represents a percentage change to the velocity calculated by a logic or motion program or set by a switch for a <see cref="Rotary">Rotary</see> type axis.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		ROTARY_VELOCITY_OVERRIDE,
		/// <summary>
		﻿/// <see cref="EventEnum.SERIAL_NUMBER" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
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
		SPINDLE_INTERLOCK,
		/// <summary>
		﻿/// <see cref="EventEnum.TOOL_ASSET_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		TOOL_ASSET_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.TOOL_GROUP" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
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
		TOOL_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.TOOL_NUMBER" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
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
		USER,
		/// <summary>
		﻿/// <see cref="EventEnum.VARIABLE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
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
		WAIT_STATE,
		/// <summary>
		﻿/// <see cref="EventEnum.WIRE" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		WIRE,
		/// <summary>
		﻿/// <see cref="EventEnum.WORKHOLDING_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		WORKHOLDING_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.WORK_OFFSET" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
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
		NETWORK,
		/// <summary>
		﻿/// <see cref="EventEnum.ROTATION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		ROTATION,
		/// <summary>
		﻿/// <see cref="EventEnum.TRANSLATION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
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
		PART_STATUS,
		/// <summary>
		﻿/// <see cref="EventEnum.ALARM_LIMIT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
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
		PART_KIND_ID,
		/// <summary>
		﻿/// <see cref="EventEnum.ADAPTER_URI" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ADAPTER_U_R_I,
		/// <summary>
		﻿/// <see cref="EventEnum.DEVICE_REMOVED" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DEVICE_REMOVED,
		/// <summary>
		﻿/// <see cref="EventEnum.DEVICE_CHANGED" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DEVICE_CHANGED,
		/// <summary>
		﻿/// <see cref="EventEnum.SPECIFICATION_LIMIT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
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
		CONNECTION_STATUS,
		/// <summary>
		﻿/// <see cref="EventEnum.ADAPTER_SOFTWARE_VERSION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ADAPTER_SOFTWARE_VERSION,
		/// <summary>
		﻿/// <see cref="EventEnum.SENSOR_ATTACHMENT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		SENSOR_ATTACHMENT,
		/// <summary>
		﻿/// <see cref="EventEnum.CONTROL_LIMIT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		CONTROL_LIMIT,
		/// <summary>
		﻿/// <see cref="EventEnum.DEVICE_ADDED" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DEVICE_ADDED,
		/// <summary>
		﻿/// <see cref="EventEnum.MTCONNECT_VERSION" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
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
		OPERATING_MODE,
		/// <summary>
		﻿/// <see cref="EventEnum.ASSET_COUNT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		ASSET_COUNT,
		/// <summary>
		﻿/// <see cref="EventEnum.MAINTENANCE_LIST" />  If the <see cref="INTERVAL" /> <see cref="key" /> is not provided, it is assumed <c>ABSOLUTE</c>.  If the <see cref="DIRECTION" /> <see cref="key" /> is not provided, it is assumed <c>UP</c>.  If the <see cref="UNITS" /> <see cref="key" /> is not provided, it is assumed to be <c>COUNT</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		MAINTENANCE_LIST,
		/// <summary>
		﻿/// <see cref="EventEnum.FIXTURE_ID" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
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
		PART_COUNT_TYPE,
		/// <summary>
		﻿/// <see cref="EventEnum.CLOCK_TIME" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		CLOCK_TIME,
		/// <summary>
		﻿/// <see cref="EventEnum.NETWORK_PORT" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		NETWORK_PORT,
		/// <summary>
		﻿/// <see cref="EventEnum.HOST_NAME" />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
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
		BATTERY_STATE,
	}
}