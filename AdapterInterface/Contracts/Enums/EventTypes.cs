#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterInterface.Contracts.Attributes;
using Mtconnect.AdapterInterface.DataItemValues;

namespace Mtconnect.AdapterInterface.DataItemTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__">model.mtconnect.org</seealso>
	﻿	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.14.0")]
	public enum EventTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// {{def(EventEnum:ACTIVE_AXES)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		ACTIVE_AXES,
		/// <summary>
		﻿/// {{def(EventEnum:ACTUATOR_STATE)}}
		/// <br/><b>Values</b>: <see cref="ActuatorStateValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		[ObservationalValue(typeof(ActuatorStateValues))]
		ACTUATOR_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:ALARM)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		ALARM,
		/// <summary>
		﻿/// {{def(EventEnum:ASSET_CHANGED)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		ASSET_CHANGED,
		/// <summary>
		﻿/// {{def(EventEnum:ASSET_REMOVED)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		ASSET_REMOVED,
		/// <summary>
		﻿/// {{def(EventEnum:AVAILABILITY)}}
		/// <br/><b>Values</b>: <see cref="AvailabilityValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		[ObservationalValue(typeof(AvailabilityValues))]
		AVAILABILITY,
		/// <summary>
		﻿/// {{def(EventEnum:AXIS_COUPLING)}}
		/// <br/><b>Values</b>: <see cref="AxisCouplingValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		[ObservationalValue(typeof(AxisCouplingValues))]
		AXIS_COUPLING,
		/// <summary>
		﻿/// {{def(EventEnum:AXIS_FEEDRATE_OVERRIDE)}}
		/// <br/><b>Sub-Type</b>: <see cref="AxisFeedrateOverrideSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		[ObservationalSubType(typeof(AxisFeedrateOverrideSubTypes))]
		AXIS_FEEDRATE_OVERRIDE,
		/// <summary>
		﻿/// {{def(EventEnum:AXIS_INTERLOCK)}}
		/// <br/><b>Values</b>: <see cref="AxisInterlockValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		[ObservationalValue(typeof(AxisInterlockValues))]
		AXIS_INTERLOCK,
		/// <summary>
		﻿/// {{def(EventEnum:AXIS_STATE)}}
		/// <br/><b>Values</b>: <see cref="AxisStateValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		[ObservationalValue(typeof(AxisStateValues))]
		AXIS_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:BLOCK)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		BLOCK,
		/// <summary>
		﻿/// {{def(EventEnum:BLOCK_COUNT)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		BLOCK_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:CHUCK_INTERLOCK)}}
		/// <br/><b>Sub-Type</b>: <see cref="ChuckInterlockSubTypes" />
		/// <br/><b>Values</b>: <see cref="ChuckInterlockValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		[ObservationalSubType(typeof(ChuckInterlockSubTypes))]
		[ObservationalValue(typeof(ChuckInterlockValues))]
		CHUCK_INTERLOCK,
		/// <summary>
		﻿/// {{def(EventEnum:CHUCK_STATE)}}
		/// <br/><b>Values</b>: <see cref="ChuckStateValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		[ObservationalValue(typeof(ChuckStateValues))]
		CHUCK_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:CODE)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		CODE,
		/// <summary>
		﻿/// {{def(EventEnum:COMPOSITION_STATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="CompositionStateSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		[ObservationalSubType(typeof(CompositionStateSubTypes))]
		COMPOSITION_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:CONTROLLER_MODE)}}
		/// <br/><b>Values</b>: <see cref="ControllerModeValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		[ObservationalValue(typeof(ControllerModeValues))]
		CONTROLLER_MODE,
		/// <summary>
		﻿/// {{def(EventEnum:CONTROLLER_MODE_OVERRIDE)}}
		/// <br/><b>Sub-Type</b>: <see cref="ControllerModeOverrideSubTypes" />
		/// <br/><b>Values</b>: <see cref="ControllerModeOverrideValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		[ObservationalSubType(typeof(ControllerModeOverrideSubTypes))]
		[ObservationalValue(typeof(ControllerModeOverrideValues))]
		CONTROLLER_MODE_OVERRIDE,
		/// <summary>
		﻿/// {{def(EventEnum:COUPLED_AXES)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		COUPLED_AXES,
		/// <summary>
		﻿/// {{def(EventEnum:DATE_CODE)}}
		/// <br/><b>Sub-Type</b>: <see cref="DateCodeSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalSubType(typeof(DateCodeSubTypes))]
		DATE_CODE,
		/// <summary>
		﻿/// {{def(EventEnum:DEVICE_UUID)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		DEVICE_UUID,
		/// <summary>
		﻿/// {{def(EventEnum:DIRECTION)}}
		/// <br/><b>Sub-Type</b>: <see cref="DirectionSubTypes" />
		/// <br/><b>Values</b>: <see cref="DirectionValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		[ObservationalSubType(typeof(DirectionSubTypes))]
		[ObservationalValue(typeof(DirectionValues))]
		DIRECTION,
		/// <summary>
		﻿/// {{def(EventEnum:DOOR_STATE)}}
		/// <br/><b>Values</b>: <see cref="DoorStateValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		[ObservationalValue(typeof(DoorStateValues))]
		DOOR_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:EMERGENCY_STOP)}}
		/// <br/><b>Values</b>: <see cref="EmergencyStopValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		[ObservationalValue(typeof(EmergencyStopValues))]
		EMERGENCY_STOP,
		/// <summary>
		﻿/// {{def(EventEnum:END_OF_BAR)}}
		/// <br/><b>Sub-Type</b>: <see cref="EndOfBarSubTypes" />
		/// <br/><b>Values</b>: <see cref="EndOfBarValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		[ObservationalSubType(typeof(EndOfBarSubTypes))]
		[ObservationalValue(typeof(EndOfBarValues))]
		END_OF_BAR,
		/// <summary>
		﻿/// {{def(EventEnum:EQUIPMENT_MODE)}}
		/// <br/><b>Sub-Type</b>: <see cref="EquipmentModeSubTypes" />
		/// <br/><b>Values</b>: <see cref="EquipmentModeValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		[ObservationalSubType(typeof(EquipmentModeSubTypes))]
		[ObservationalValue(typeof(EquipmentModeValues))]
		EQUIPMENT_MODE,
		/// <summary>
		﻿/// {{def(EventEnum:EXECUTION)}}
		/// <br/><b>Values</b>: <see cref="ExecutionValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		[ObservationalValue(typeof(ExecutionValues))]
		EXECUTION,
		/// <summary>
		﻿/// {{def(EventEnum:FUNCTIONAL_MODE)}}
		/// <br/><b>Values</b>: <see cref="FunctionalModeValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		[ObservationalValue(typeof(FunctionalModeValues))]
		FUNCTIONAL_MODE,
		/// <summary>
		﻿/// {{def(EventEnum:HARDNESS)}}
		/// <br/><b>Sub-Type</b>: <see cref="HardnessSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		[ObservationalSubType(typeof(HardnessSubTypes))]
		HARDNESS,
		/// <summary>
		﻿/// {{def(EventEnum:LINE)}}
		/// <br/><b>Sub-Type</b>: <see cref="LineSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
		[ObservationalSubType(typeof(LineSubTypes))]
		LINE,
		/// <summary>
		﻿/// {{def(EventEnum:LINE_LABEL)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		LINE_LABEL,
		/// <summary>
		﻿/// {{def(EventEnum:LINE_NUMBER)}}
		/// <br/><b>Sub-Type</b>: <see cref="LineNumberSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		[ObservationalSubType(typeof(LineNumberSubTypes))]
		LINE_NUMBER,
		/// <summary>
		﻿/// {{def(EventEnum:MATERIAL)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		MATERIAL,
		/// <summary>
		﻿/// {{def(EventEnum:MATERIAL_LAYER)}}
		/// <br/><b>Sub-Type</b>: <see cref="MaterialLayerSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalSubType(typeof(MaterialLayerSubTypes))]
		MATERIAL_LAYER,
		/// <summary>
		﻿/// {{def(EventEnum:MESSAGE)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		MESSAGE,
		/// <summary>
		﻿/// {{def(EventEnum:OPERATOR_ID)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		OPERATOR_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PALLET_ID)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		PALLET_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PART_COUNT)}}
		/// <br/><b>Sub-Type</b>: <see cref="PartCountSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		[ObservationalSubType(typeof(PartCountSubTypes))]
		PART_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:PART_DETECT)}}
		/// <br/><b>Values</b>: <see cref="PartDetectValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalValue(typeof(PartDetectValues))]
		PART_DETECT,
		/// <summary>
		﻿/// {{def(EventEnum:PART_ID)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		PART_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PART_NUMBER)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		[Obsolete("Deprecated in v1.7 according to https://model.mtconnect.org/#_Version_1.7")]
		PART_NUMBER,
		/// <summary>
		﻿/// {{def(EventEnum:PATH_FEEDRATE_OVERRIDE)}}
		/// <br/><b>Sub-Type</b>: <see cref="PathFeedrateOverrideSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		[ObservationalSubType(typeof(PathFeedrateOverrideSubTypes))]
		PATH_FEEDRATE_OVERRIDE,
		/// <summary>
		﻿/// {{def(EventEnum:PATH_MODE)}}
		/// <br/><b>Values</b>: <see cref="PathModeValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		[ObservationalValue(typeof(PathModeValues))]
		PATH_MODE,
		/// <summary>
		﻿/// {{def(EventEnum:POWER_STATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="PowerStateSubTypes" />
		/// <br/><b>Values</b>: <see cref="PowerStateValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		[ObservationalSubType(typeof(PowerStateSubTypes))]
		[ObservationalValue(typeof(PowerStateValues))]
		POWER_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:POWER_STATUS)}}
		/// <br/><b>Values</b>: <see cref="PowerStatusValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		[ObservationalValue(typeof(PowerStatusValues))]
		POWER_STATUS,
		/// <summary>
		﻿/// {{def(EventEnum:PROCESS_TIME)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProcessTimeSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalSubType(typeof(ProcessTimeSubTypes))]
		PROCESS_TIME,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProgramSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see>.</remarks>
		[ObservationalSubType(typeof(ProgramSubTypes))]
		PROGRAM,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM_COMMENT)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProgramCommentSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		[ObservationalSubType(typeof(ProgramCommentSubTypes))]
		PROGRAM_COMMENT,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM_EDIT)}}
		/// <br/><b>Values</b>: <see cref="ProgramEditValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		[ObservationalValue(typeof(ProgramEditValues))]
		PROGRAM_EDIT,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM_EDIT_NAME)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		PROGRAM_EDIT_NAME,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM_HEADER)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProgramHeaderSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		[ObservationalSubType(typeof(ProgramHeaderSubTypes))]
		PROGRAM_HEADER,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM_LOCATION)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProgramLocationSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalSubType(typeof(ProgramLocationSubTypes))]
		PROGRAM_LOCATION,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM_LOCATION_TYPE)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProgramLocationTypeSubTypes" />
		/// <br/><b>Values</b>: <see cref="ProgramLocationTypeValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalSubType(typeof(ProgramLocationTypeSubTypes))]
		[ObservationalValue(typeof(ProgramLocationTypeValues))]
		PROGRAM_LOCATION_TYPE,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM_NEST_LEVEL)}}  If an initial value is not defined, the nesting level associated with the highest or initial nesting level of the program <b>MUST</b> default to zero (0). 
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		PROGRAM_NEST_LEVEL,
		/// <summary>
		﻿/// {{def(EventEnum:ROTARY_MODE)}}
		/// <br/><b>Values</b>: <see cref="RotaryModeValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		[ObservationalValue(typeof(RotaryModeValues))]
		ROTARY_MODE,
		/// <summary>
		﻿/// {{def(EventEnum:ROTARY_VELOCITY_OVERRIDE)}}  This command represents a percentage change to the velocity calculated by a logic or motion program or set by a switch for a <see cref="Rotary">Rotary</see> type axis.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		ROTARY_VELOCITY_OVERRIDE,
		/// <summary>
		﻿/// {{def(EventEnum:SERIAL_NUMBER)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		SERIAL_NUMBER,
		/// <summary>
		﻿/// {{def(EventEnum:SPINDLE_INTERLOCK)}}
		/// <br/><b>Values</b>: <see cref="SpindleInterlockValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see>.</remarks>
		[ObservationalValue(typeof(SpindleInterlockValues))]
		SPINDLE_INTERLOCK,
		/// <summary>
		﻿/// {{def(EventEnum:TOOL_ASSET_ID)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		TOOL_ASSET_ID,
		/// <summary>
		﻿/// {{def(EventEnum:TOOL_GROUP)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		TOOL_GROUP,
		/// <summary>
		﻿/// {{def(EventEnum:TOOL_ID)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		/// <remarks>Deprecated in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		TOOL_ID,
		/// <summary>
		﻿/// {{def(EventEnum:TOOL_NUMBER)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		TOOL_NUMBER,
		/// <summary>
		﻿/// {{def(EventEnum:TOOL_OFFSET)}}
		/// <br/><b>Sub-Type</b>: <see cref="ToolOffsetSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		[ObservationalSubType(typeof(ToolOffsetSubTypes))]
		TOOL_OFFSET,
		/// <summary>
		﻿/// {{def(EventEnum:USER)}}
		/// <br/><b>Sub-Type</b>: <see cref="UserSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		[ObservationalSubType(typeof(UserSubTypes))]
		USER,
		/// <summary>
		﻿/// {{def(EventEnum:VARIABLE)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		VARIABLE,
		/// <summary>
		﻿/// {{def(EventEnum:WAIT_STATE)}}
		/// <br/><b>Values</b>: <see cref="WaitStateValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see>.</remarks>
		[ObservationalValue(typeof(WaitStateValues))]
		WAIT_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:WIRE)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		WIRE,
		/// <summary>
		﻿/// {{def(EventEnum:WORKHOLDING_ID)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see>.</remarks>
		WORKHOLDING_ID,
		/// <summary>
		﻿/// {{def(EventEnum:WORK_OFFSET)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		WORK_OFFSET,
		/// <summary>
		﻿/// {{def(EventEnum:OPERATING_SYSTEM)}}
		/// <br/><b>Sub-Type</b>: <see cref="OperatingSystemSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[ObservationalSubType(typeof(OperatingSystemSubTypes))]
		OPERATING_SYSTEM,
		/// <summary>
		﻿/// {{def(EventEnum:FIRMWARE)}}
		/// <br/><b>Sub-Type</b>: <see cref="FirmwareSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[ObservationalSubType(typeof(FirmwareSubTypes))]
		FIRMWARE,
		/// <summary>
		﻿/// {{def(EventEnum:APPLICATION)}}
		/// <br/><b>Sub-Type</b>: <see cref="ApplicationSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[ObservationalSubType(typeof(ApplicationSubTypes))]
		APPLICATION,
		/// <summary>
		﻿/// {{def(EventEnum:LIBRARY)}}
		/// <br/><b>Sub-Type</b>: <see cref="LibrarySubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[ObservationalSubType(typeof(LibrarySubTypes))]
		LIBRARY,
		/// <summary>
		﻿/// {{def(EventEnum:HARDWARE)}}
		/// <br/><b>Sub-Type</b>: <see cref="HardwareSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see>.</remarks>
		[ObservationalSubType(typeof(HardwareSubTypes))]
		HARDWARE,
		/// <summary>
		﻿/// {{def(EventEnum:NETWORK)}}
		/// <br/><b>Sub-Type</b>: <see cref="NetworkSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		[ObservationalSubType(typeof(NetworkSubTypes))]
		NETWORK,
		/// <summary>
		﻿/// {{def(EventEnum:ROTATION)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		ROTATION,
		/// <summary>
		﻿/// {{def(EventEnum:TRANSLATION)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see>.</remarks>
		TRANSLATION,
		/// <summary>
		﻿/// {{def(EventEnum:PROCESS_KIND_ID)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProcessKindIdSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		[ObservationalSubType(typeof(ProcessKindIdSubTypes))]
		PROCESS_KIND_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PART_STATUS)}}  If unique identifier is given, part status is for that individual. If group identifier is given without a unique identifier, then the status is assumed to be for the whole group.
		/// <br/><b>Values</b>: <see cref="PartStatusValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		[ObservationalValue(typeof(PartStatusValues))]
		PART_STATUS,
		/// <summary>
		﻿/// {{def(EventEnum:ALARM_LIMIT)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		ALARM_LIMIT,
		/// <summary>
		﻿/// {{def(EventEnum:PROCESS_AGGREGATE_ID)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProcessAggregateIdSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		[ObservationalSubType(typeof(ProcessAggregateIdSubTypes))]
		PROCESS_AGGREGATE_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PART_KIND_ID)}}  If no {{property(subType)}} is specified, <c>UUID</c> is default. 
		/// <br/><b>Sub-Type</b>: <see cref="PartKindIdSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		[ObservationalSubType(typeof(PartKindIdSubTypes))]
		PART_KIND_ID,
		/// <summary>
		﻿/// {{def(EventEnum:ADAPTER_URI)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		ADAPTER_U_R_I,
		/// <summary>
		﻿/// {{def(EventEnum:DEVICE_REMOVED)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		DEVICE_REMOVED,
		/// <summary>
		﻿/// {{def(EventEnum:DEVICE_CHANGED)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		DEVICE_CHANGED,
		/// <summary>
		﻿/// {{def(EventEnum:SPECIFICATION_LIMIT)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		SPECIFICATION_LIMIT,
		/// <summary>
		﻿/// {{def(EventEnum:CONNECTION_STATUS)}}
		/// <br/><b>Values</b>: <see cref="ConnectionStatusValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		[ObservationalValue(typeof(ConnectionStatusValues))]
		CONNECTION_STATUS,
		/// <summary>
		﻿/// {{def(EventEnum:ADAPTER_SOFTWARE_VERSION)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		ADAPTER_SOFTWARE_VERSION,
		/// <summary>
		﻿/// {{def(EventEnum:SENSOR_ATTACHMENT)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		SENSOR_ATTACHMENT,
		/// <summary>
		﻿/// {{def(EventEnum:CONTROL_LIMIT)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		CONTROL_LIMIT,
		/// <summary>
		﻿/// {{def(EventEnum:DEVICE_ADDED)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		DEVICE_ADDED,
		/// <summary>
		﻿/// {{def(EventEnum:MTCONNECT_VERSION)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		M_T_CONNECT_VERSION,
		/// <summary>
		﻿/// {{def(EventEnum:PROCESS_OCCURRENCE_ID)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProcessOccurrenceIdSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		[ObservationalSubType(typeof(ProcessOccurrenceIdSubTypes))]
		PROCESS_OCCURRENCE_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PART_GROUP_ID)}}  If no {{property(subType)}} is specified, <c>UUID</c> is default.
		/// <br/><b>Sub-Type</b>: <see cref="PartGroupIdSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		[ObservationalSubType(typeof(PartGroupIdSubTypes))]
		PART_GROUP_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PART_UNIQUE_ID)}}  If no {{property(subType)}} is specified, <c>UUID</c> is default. 
		/// <br/><b>Sub-Type</b>: <see cref="PartUniqueIdSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see>.</remarks>
		[ObservationalSubType(typeof(PartUniqueIdSubTypes))]
		PART_UNIQUE_ID,
		/// <summary>
		﻿/// {{def(EventEnum:ACTIVATION_COUNT)}}
		/// <br/><b>Sub-Type</b>: <see cref="ActivationCountSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		[ObservationalSubType(typeof(ActivationCountSubTypes))]
		ACTIVATION_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:DEACTIVATION_COUNT)}}
		/// <br/><b>Sub-Type</b>: <see cref="DeactivationCountSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		[ObservationalSubType(typeof(DeactivationCountSubTypes))]
		DEACTIVATION_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:TRANSFER_COUNT)}}
		/// <br/><b>Sub-Type</b>: <see cref="TransferCountSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		[ObservationalSubType(typeof(TransferCountSubTypes))]
		TRANSFER_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:LOAD_COUNT)}}
		/// <br/><b>Sub-Type</b>: <see cref="LoadCountSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		[ObservationalSubType(typeof(LoadCountSubTypes))]
		LOAD_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:PART_PROCESSING_STATE)}}
		/// <br/><b>Values</b>: <see cref="PartProcessingStateValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		[ObservationalValue(typeof(PartProcessingStateValues))]
		PART_PROCESSING_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:PROCESS_STATE)}}
		/// <br/><b>Values</b>: <see cref="ProcessStateValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		[ObservationalValue(typeof(ProcessStateValues))]
		PROCESS_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:VALVE_STATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="ValveStateSubTypes" />
		/// <br/><b>Values</b>: <see cref="ValveStateValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		[ObservationalSubType(typeof(ValveStateSubTypes))]
		[ObservationalValue(typeof(ValveStateValues))]
		VALVE_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:LOCK_STATE)}}
		/// <br/><b>Values</b>: <see cref="LockStateValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		[ObservationalValue(typeof(LockStateValues))]
		LOCK_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:UNLOAD_COUNT)}}
		/// <br/><b>Sub-Type</b>: <see cref="UnloadCountSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		[ObservationalSubType(typeof(UnloadCountSubTypes))]
		UNLOAD_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:CYCLE_COUNT)}}
		/// <br/><b>Sub-Type</b>: <see cref="CycleCountSubTypes" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see>.</remarks>
		[ObservationalSubType(typeof(CycleCountSubTypes))]
		CYCLE_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:OPERATING_MODE)}}
		/// <br/><b>Values</b>: <see cref="OperatingModeValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see>.</remarks>
		[ObservationalValue(typeof(OperatingModeValues))]
		OPERATING_MODE,
		/// <summary>
		﻿/// {{def(EventEnum:ASSET_COUNT)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see>.</remarks>
		ASSET_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:MAINTENANCE_LIST)}}  If the {{property(INTERVAL)}} {{property(key)}} is not provided, it is assumed <c>ABSOLUTE</c>.  If the {{property(DIRECTION)}} {{property(key)}} is not provided, it is assumed <c>UP</c>.  If the {{property(UNITS)}} {{property(key)}} is not provided, it is assumed to be <c>COUNT</c>.
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see>.</remarks>
		MAINTENANCE_LIST,
		/// <summary>
		﻿/// {{def(EventEnum:FIXTURE_ID)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see>.</remarks>
		FIXTURE_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PART_COUNT_TYPE)}}
		/// <br/><b>Values</b>: <see cref="PartCountTypeValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see>.</remarks>
		[ObservationalValue(typeof(PartCountTypeValues))]
		PART_COUNT_TYPE,
		/// <summary>
		﻿/// {{def(EventEnum:CLOCK_TIME)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see>.</remarks>
		CLOCK_TIME,
		/// <summary>
		﻿/// {{def(EventEnum:NETWORK_PORT)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		NETWORK_PORT,
		/// <summary>
		﻿/// {{def(EventEnum:HOST_NAME)}}
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		HOST_NAME,
		/// <summary>
		﻿/// {{def(EventEnum:LEAK_DETECT)}}
		/// <br/><b>Values</b>: <see cref="LeakDetectValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		[ObservationalValue(typeof(LeakDetectValues))]
		LEAK_DETECT,
		/// <summary>
		﻿/// {{def(EventEnum:BATTERY_STATE)}}
		/// <br/><b>Values</b>: <see cref="BatteryStateValues" />
		/// </summary>
		/// <remarks>Introduced in <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see>.</remarks>
		[ObservationalValue(typeof(BatteryStateValues))]
		BATTERY_STATE,
	}
}