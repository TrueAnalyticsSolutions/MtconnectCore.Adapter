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
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "0.0.12.0")]
	public enum EventTypes
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// {{def(EventEnum:ACTIVE_AXES)}}
		/// </summary>
		ACTIVE_AXES,
		/// <summary>
		﻿/// {{def(EventEnum:ACTUATOR_STATE)}}
		/// <br/><b>Values</b>: <see cref="ActuatorStateValues" />
		/// </summary>
		[ObservationalValue(typeof(ActuatorStateValues))]
		ACTUATOR_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:ALARM)}}
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_1_0")]
		ALARM,
		/// <summary>
		﻿/// {{def(EventEnum:ASSET_CHANGED)}}
		/// </summary>
		ASSET_CHANGED,
		/// <summary>
		﻿/// {{def(EventEnum:ASSET_REMOVED)}}
		/// </summary>
		ASSET_REMOVED,
		/// <summary>
		﻿/// {{def(EventEnum:AVAILABILITY)}}
		/// <br/><b>Values</b>: <see cref="AvailabilityValues" />
		/// </summary>
		[ObservationalValue(typeof(AvailabilityValues))]
		AVAILABILITY,
		/// <summary>
		﻿/// {{def(EventEnum:AXIS_COUPLING)}}
		/// <br/><b>Values</b>: <see cref="AxisCouplingValues" />
		/// </summary>
		[ObservationalValue(typeof(AxisCouplingValues))]
		AXIS_COUPLING,
		/// <summary>
		﻿/// {{def(EventEnum:AXIS_FEEDRATE_OVERRIDE)}}
		/// <br/><b>Sub-Type</b>: <see cref="AxisFeedrateOverrideSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(AxisFeedrateOverrideSubTypes))]
		AXIS_FEEDRATE_OVERRIDE,
		/// <summary>
		﻿/// {{def(EventEnum:AXIS_INTERLOCK)}}
		/// <br/><b>Values</b>: <see cref="AxisInterlockValues" />
		/// </summary>
		[ObservationalValue(typeof(AxisInterlockValues))]
		AXIS_INTERLOCK,
		/// <summary>
		﻿/// {{def(EventEnum:AXIS_STATE)}}
		/// <br/><b>Values</b>: <see cref="AxisStateValues" />
		/// </summary>
		[ObservationalValue(typeof(AxisStateValues))]
		AXIS_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:BLOCK)}}
		/// </summary>
		BLOCK,
		/// <summary>
		﻿/// {{def(EventEnum:BLOCK_COUNT)}}
		/// </summary>
		BLOCK_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:CHUCK_INTERLOCK)}}
		/// <br/><b>Sub-Type</b>: <see cref="ChuckInterlockSubTypes" />
		/// <br/><b>Values</b>: <see cref="ChuckInterlockValues" />
		/// </summary>
		[ObservationalSubType(typeof(ChuckInterlockSubTypes))]
		[ObservationalValue(typeof(ChuckInterlockValues))]
		CHUCK_INTERLOCK,
		/// <summary>
		﻿/// {{def(EventEnum:CHUCK_STATE)}}
		/// <br/><b>Values</b>: <see cref="ChuckStateValues" />
		/// </summary>
		[ObservationalValue(typeof(ChuckStateValues))]
		CHUCK_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:CODE)}}
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_1_0")]
		CODE,
		/// <summary>
		﻿/// {{def(EventEnum:COMPOSITION_STATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="CompositionStateSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(CompositionStateSubTypes))]
		COMPOSITION_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:CONTROLLER_MODE)}}
		/// <br/><b>Values</b>: <see cref="ControllerModeValues" />
		/// </summary>
		[ObservationalValue(typeof(ControllerModeValues))]
		CONTROLLER_MODE,
		/// <summary>
		﻿/// {{def(EventEnum:CONTROLLER_MODE_OVERRIDE)}}
		/// <br/><b>Sub-Type</b>: <see cref="ControllerModeOverrideSubTypes" />
		/// <br/><b>Values</b>: <see cref="ControllerModeOverrideValues" />
		/// </summary>
		[ObservationalSubType(typeof(ControllerModeOverrideSubTypes))]
		[ObservationalValue(typeof(ControllerModeOverrideValues))]
		CONTROLLER_MODE_OVERRIDE,
		/// <summary>
		﻿/// {{def(EventEnum:COUPLED_AXES)}}
		/// </summary>
		COUPLED_AXES,
		/// <summary>
		﻿/// {{def(EventEnum:DATE_CODE)}}
		/// <br/><b>Sub-Type</b>: <see cref="DateCodeSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(DateCodeSubTypes))]
		DATE_CODE,
		/// <summary>
		﻿/// {{def(EventEnum:DEVICE_UUID)}}
		/// </summary>
		DEVICE_UUID,
		/// <summary>
		﻿/// {{def(EventEnum:DIRECTION)}}
		/// <br/><b>Sub-Type</b>: <see cref="DirectionSubTypes" />
		/// <br/><b>Values</b>: <see cref="DirectionValues" />
		/// </summary>
		[ObservationalSubType(typeof(DirectionSubTypes))]
		[ObservationalValue(typeof(DirectionValues))]
		DIRECTION,
		/// <summary>
		﻿/// {{def(EventEnum:DOOR_STATE)}}
		/// <br/><b>Values</b>: <see cref="DoorStateValues" />
		/// </summary>
		[ObservationalValue(typeof(DoorStateValues))]
		DOOR_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:EMERGENCY_STOP)}}
		/// <br/><b>Values</b>: <see cref="EmergencyStopValues" />
		/// </summary>
		[ObservationalValue(typeof(EmergencyStopValues))]
		EMERGENCY_STOP,
		/// <summary>
		﻿/// {{def(EventEnum:END_OF_BAR)}}
		/// <br/><b>Sub-Type</b>: <see cref="EndOfBarSubTypes" />
		/// <br/><b>Values</b>: <see cref="EndOfBarValues" />
		/// </summary>
		[ObservationalSubType(typeof(EndOfBarSubTypes))]
		[ObservationalValue(typeof(EndOfBarValues))]
		END_OF_BAR,
		/// <summary>
		﻿/// {{def(EventEnum:EQUIPMENT_MODE)}}
		/// <br/><b>Sub-Type</b>: <see cref="EquipmentModeSubTypes" />
		/// <br/><b>Values</b>: <see cref="EquipmentModeValues" />
		/// </summary>
		[ObservationalSubType(typeof(EquipmentModeSubTypes))]
		[ObservationalValue(typeof(EquipmentModeValues))]
		EQUIPMENT_MODE,
		/// <summary>
		﻿/// {{def(EventEnum:EXECUTION)}}
		/// <br/><b>Values</b>: <see cref="ExecutionValues" />
		/// </summary>
		[ObservationalValue(typeof(ExecutionValues))]
		EXECUTION,
		/// <summary>
		﻿/// {{def(EventEnum:FUNCTIONAL_MODE)}}
		/// <br/><b>Values</b>: <see cref="FunctionalModeValues" />
		/// </summary>
		[ObservationalValue(typeof(FunctionalModeValues))]
		FUNCTIONAL_MODE,
		/// <summary>
		﻿/// {{def(EventEnum:HARDNESS)}}
		/// <br/><b>Sub-Type</b>: <see cref="HardnessSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(HardnessSubTypes))]
		HARDNESS,
		/// <summary>
		﻿/// {{def(EventEnum:LINE)}}
		/// <br/><b>Sub-Type</b>: <see cref="LineSubTypes" />
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_4_0")]
		[ObservationalSubType(typeof(LineSubTypes))]
		LINE,
		/// <summary>
		﻿/// {{def(EventEnum:LINE_LABEL)}}
		/// </summary>
		LINE_LABEL,
		/// <summary>
		﻿/// {{def(EventEnum:LINE_NUMBER)}}
		/// <br/><b>Sub-Type</b>: <see cref="LineNumberSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(LineNumberSubTypes))]
		LINE_NUMBER,
		/// <summary>
		﻿/// {{def(EventEnum:MATERIAL)}}
		/// </summary>
		MATERIAL,
		/// <summary>
		﻿/// {{def(EventEnum:MATERIAL_LAYER)}}
		/// <br/><b>Sub-Type</b>: <see cref="MaterialLayerSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(MaterialLayerSubTypes))]
		MATERIAL_LAYER,
		/// <summary>
		﻿/// {{def(EventEnum:MESSAGE)}}
		/// </summary>
		MESSAGE,
		/// <summary>
		﻿/// {{def(EventEnum:OPERATOR_ID)}}
		/// </summary>
		OPERATOR_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PALLET_ID)}}
		/// </summary>
		PALLET_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PART_COUNT)}}
		/// <br/><b>Sub-Type</b>: <see cref="PartCountSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(PartCountSubTypes))]
		PART_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:PART_DETECT)}}
		/// <br/><b>Values</b>: <see cref="PartDetectValues" />
		/// </summary>
		[ObservationalValue(typeof(PartDetectValues))]
		PART_DETECT,
		/// <summary>
		﻿/// {{def(EventEnum:PART_ID)}}
		/// </summary>
		PART_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PART_NUMBER)}}
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_7_0")]
		PART_NUMBER,
		/// <summary>
		﻿/// {{def(EventEnum:PATH_FEEDRATE_OVERRIDE)}}
		/// <br/><b>Sub-Type</b>: <see cref="PathFeedrateOverrideSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(PathFeedrateOverrideSubTypes))]
		PATH_FEEDRATE_OVERRIDE,
		/// <summary>
		﻿/// {{def(EventEnum:PATH_MODE)}}
		/// <br/><b>Values</b>: <see cref="PathModeValues" />
		/// </summary>
		[ObservationalValue(typeof(PathModeValues))]
		PATH_MODE,
		/// <summary>
		﻿/// {{def(EventEnum:POWER_STATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="PowerStateSubTypes" />
		/// <br/><b>Values</b>: <see cref="PowerStateValues" />
		/// </summary>
		[ObservationalSubType(typeof(PowerStateSubTypes))]
		[ObservationalValue(typeof(PowerStateValues))]
		POWER_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:POWER_STATUS)}}
		/// <br/><b>Values</b>: <see cref="PowerStatusValues" />
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_1_0")]
		[ObservationalValue(typeof(PowerStatusValues))]
		POWER_STATUS,
		/// <summary>
		﻿/// {{def(EventEnum:PROCESS_TIME)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProcessTimeSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(ProcessTimeSubTypes))]
		PROCESS_TIME,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProgramSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(ProgramSubTypes))]
		PROGRAM,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM_COMMENT)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProgramCommentSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(ProgramCommentSubTypes))]
		PROGRAM_COMMENT,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM_EDIT)}}
		/// <br/><b>Values</b>: <see cref="ProgramEditValues" />
		/// </summary>
		[ObservationalValue(typeof(ProgramEditValues))]
		PROGRAM_EDIT,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM_EDIT_NAME)}}
		/// </summary>
		PROGRAM_EDIT_NAME,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM_HEADER)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProgramHeaderSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(ProgramHeaderSubTypes))]
		PROGRAM_HEADER,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM_LOCATION)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProgramLocationSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(ProgramLocationSubTypes))]
		PROGRAM_LOCATION,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM_LOCATION_TYPE)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProgramLocationTypeSubTypes" />
		/// <br/><b>Values</b>: <see cref="ProgramLocationTypeValues" />
		/// </summary>
		[ObservationalSubType(typeof(ProgramLocationTypeSubTypes))]
		[ObservationalValue(typeof(ProgramLocationTypeValues))]
		PROGRAM_LOCATION_TYPE,
		/// <summary>
		﻿/// {{def(EventEnum:PROGRAM_NEST_LEVEL)}}  If an initial value is not defined, the nesting level associated with the highest or initial nesting level of the program <b>MUST</b> default to zero (0). 
		/// </summary>
		PROGRAM_NEST_LEVEL,
		/// <summary>
		﻿/// {{def(EventEnum:ROTARY_MODE)}}
		/// <br/><b>Values</b>: <see cref="RotaryModeValues" />
		/// </summary>
		[ObservationalValue(typeof(RotaryModeValues))]
		ROTARY_MODE,
		/// <summary>
		﻿/// {{def(EventEnum:ROTARY_VELOCITY_OVERRIDE)}}  This command represents a percentage change to the velocity calculated by a logic or motion program or set by a switch for a <see cref="Rotary">Rotary</see> type axis.
		/// </summary>
		ROTARY_VELOCITY_OVERRIDE,
		/// <summary>
		﻿/// {{def(EventEnum:SERIAL_NUMBER)}}
		/// </summary>
		SERIAL_NUMBER,
		/// <summary>
		﻿/// {{def(EventEnum:SPINDLE_INTERLOCK)}}
		/// <br/><b>Values</b>: <see cref="SpindleInterlockValues" />
		/// </summary>
		[ObservationalValue(typeof(SpindleInterlockValues))]
		SPINDLE_INTERLOCK,
		/// <summary>
		﻿/// {{def(EventEnum:TOOL_ASSET_ID)}}
		/// </summary>
		TOOL_ASSET_ID,
		/// <summary>
		﻿/// {{def(EventEnum:TOOL_GROUP)}}
		/// </summary>
		TOOL_GROUP,
		/// <summary>
		﻿/// {{def(EventEnum:TOOL_ID)}}
		/// </summary>
		[Obsolete("Deprecated according to https://model.mtconnect.org/ in MtconnectVersions.V_1_2_0")]
		TOOL_ID,
		/// <summary>
		﻿/// {{def(EventEnum:TOOL_NUMBER)}}
		/// </summary>
		TOOL_NUMBER,
		/// <summary>
		﻿/// {{def(EventEnum:TOOL_OFFSET)}}
		/// <br/><b>Sub-Type</b>: <see cref="ToolOffsetSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(ToolOffsetSubTypes))]
		TOOL_OFFSET,
		/// <summary>
		﻿/// {{def(EventEnum:USER)}}
		/// <br/><b>Sub-Type</b>: <see cref="UserSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(UserSubTypes))]
		USER,
		/// <summary>
		﻿/// {{def(EventEnum:VARIABLE)}}
		/// </summary>
		VARIABLE,
		/// <summary>
		﻿/// {{def(EventEnum:WAIT_STATE)}}
		/// <br/><b>Values</b>: <see cref="WaitStateValues" />
		/// </summary>
		[ObservationalValue(typeof(WaitStateValues))]
		WAIT_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:WIRE)}}
		/// </summary>
		WIRE,
		/// <summary>
		﻿/// {{def(EventEnum:WORKHOLDING_ID)}}
		/// </summary>
		WORKHOLDING_ID,
		/// <summary>
		﻿/// {{def(EventEnum:WORK_OFFSET)}}
		/// </summary>
		WORK_OFFSET,
		/// <summary>
		﻿/// {{def(EventEnum:OPERATING_SYSTEM)}}
		/// <br/><b>Sub-Type</b>: <see cref="OperatingSystemSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(OperatingSystemSubTypes))]
		OPERATING_SYSTEM,
		/// <summary>
		﻿/// {{def(EventEnum:FIRMWARE)}}
		/// <br/><b>Sub-Type</b>: <see cref="FirmwareSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(FirmwareSubTypes))]
		FIRMWARE,
		/// <summary>
		﻿/// {{def(EventEnum:APPLICATION)}}
		/// <br/><b>Sub-Type</b>: <see cref="ApplicationSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(ApplicationSubTypes))]
		APPLICATION,
		/// <summary>
		﻿/// {{def(EventEnum:LIBRARY)}}
		/// <br/><b>Sub-Type</b>: <see cref="LibrarySubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(LibrarySubTypes))]
		LIBRARY,
		/// <summary>
		﻿/// {{def(EventEnum:HARDWARE)}}
		/// <br/><b>Sub-Type</b>: <see cref="HardwareSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(HardwareSubTypes))]
		HARDWARE,
		/// <summary>
		﻿/// {{def(EventEnum:NETWORK)}}
		/// <br/><b>Sub-Type</b>: <see cref="NetworkSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(NetworkSubTypes))]
		NETWORK,
		/// <summary>
		﻿/// {{def(EventEnum:ROTATION)}}
		/// </summary>
		ROTATION,
		/// <summary>
		﻿/// {{def(EventEnum:TRANSLATION)}}
		/// </summary>
		TRANSLATION,
		/// <summary>
		﻿/// {{def(EventEnum:PROCESS_KIND_ID)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProcessKindIdSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(ProcessKindIdSubTypes))]
		PROCESS_KIND_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PART_STATUS)}}  If unique identifier is given, part status is for that individual. If group identifier is given without a unique identifier, then the status is assumed to be for the whole group.
		/// <br/><b>Values</b>: <see cref="PartStatusValues" />
		/// </summary>
		[ObservationalValue(typeof(PartStatusValues))]
		PART_STATUS,
		/// <summary>
		﻿/// {{def(EventEnum:ALARM_LIMIT)}}
		/// </summary>
		ALARM_LIMIT,
		/// <summary>
		﻿/// {{def(EventEnum:PROCESS_AGGREGATE_ID)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProcessAggregateIdSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(ProcessAggregateIdSubTypes))]
		PROCESS_AGGREGATE_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PART_KIND_ID)}}  If no {{property(subType)}} is specified, <c>UUID</c> is default. 
		/// <br/><b>Sub-Type</b>: <see cref="PartKindIdSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(PartKindIdSubTypes))]
		PART_KIND_ID,
		/// <summary>
		﻿/// {{def(EventEnum:ADAPTER_URI)}}
		/// </summary>
		ADAPTER_U_R_I,
		/// <summary>
		﻿/// {{def(EventEnum:DEVICE_REMOVED)}}
		/// </summary>
		DEVICE_REMOVED,
		/// <summary>
		﻿/// {{def(EventEnum:DEVICE_CHANGED)}}
		/// </summary>
		DEVICE_CHANGED,
		/// <summary>
		﻿/// {{def(EventEnum:SPECIFICATION_LIMIT)}}
		/// </summary>
		SPECIFICATION_LIMIT,
		/// <summary>
		﻿/// {{def(EventEnum:CONNECTION_STATUS)}}
		/// <br/><b>Values</b>: <see cref="ConnectionStatusValues" />
		/// </summary>
		[ObservationalValue(typeof(ConnectionStatusValues))]
		CONNECTION_STATUS,
		/// <summary>
		﻿/// {{def(EventEnum:ADAPTER_SOFTWARE_VERSION)}}
		/// </summary>
		ADAPTER_SOFTWARE_VERSION,
		/// <summary>
		﻿/// {{def(EventEnum:SENSOR_ATTACHMENT)}}
		/// </summary>
		SENSOR_ATTACHMENT,
		/// <summary>
		﻿/// {{def(EventEnum:CONTROL_LIMIT)}}
		/// </summary>
		CONTROL_LIMIT,
		/// <summary>
		﻿/// {{def(EventEnum:DEVICE_ADDED)}}
		/// </summary>
		DEVICE_ADDED,
		/// <summary>
		﻿/// {{def(EventEnum:MTCONNECT_VERSION)}}
		/// </summary>
		M_T_CONNECT_VERSION,
		/// <summary>
		﻿/// {{def(EventEnum:PROCESS_OCCURRENCE_ID)}}
		/// <br/><b>Sub-Type</b>: <see cref="ProcessOccurrenceIdSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(ProcessOccurrenceIdSubTypes))]
		PROCESS_OCCURRENCE_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PART_GROUP_ID)}}  If no {{property(subType)}} is specified, <c>UUID</c> is default.
		/// <br/><b>Sub-Type</b>: <see cref="PartGroupIdSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(PartGroupIdSubTypes))]
		PART_GROUP_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PART_UNIQUE_ID)}}  If no {{property(subType)}} is specified, <c>UUID</c> is default. 
		/// <br/><b>Sub-Type</b>: <see cref="PartUniqueIdSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(PartUniqueIdSubTypes))]
		PART_UNIQUE_ID,
		/// <summary>
		﻿/// {{def(EventEnum:ACTIVATION_COUNT)}}
		/// <br/><b>Sub-Type</b>: <see cref="ActivationCountSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(ActivationCountSubTypes))]
		ACTIVATION_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:DEACTIVATION_COUNT)}}
		/// <br/><b>Sub-Type</b>: <see cref="DeactivationCountSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(DeactivationCountSubTypes))]
		DEACTIVATION_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:TRANSFER_COUNT)}}
		/// <br/><b>Sub-Type</b>: <see cref="TransferCountSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(TransferCountSubTypes))]
		TRANSFER_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:LOAD_COUNT)}}
		/// <br/><b>Sub-Type</b>: <see cref="LoadCountSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(LoadCountSubTypes))]
		LOAD_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:PART_PROCESSING_STATE)}}
		/// <br/><b>Values</b>: <see cref="PartProcessingStateValues" />
		/// </summary>
		[ObservationalValue(typeof(PartProcessingStateValues))]
		PART_PROCESSING_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:PROCESS_STATE)}}
		/// <br/><b>Values</b>: <see cref="ProcessStateValues" />
		/// </summary>
		[ObservationalValue(typeof(ProcessStateValues))]
		PROCESS_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:VALVE_STATE)}}
		/// <br/><b>Sub-Type</b>: <see cref="ValveStateSubTypes" />
		/// <br/><b>Values</b>: <see cref="ValveStateValues" />
		/// </summary>
		[ObservationalSubType(typeof(ValveStateSubTypes))]
		[ObservationalValue(typeof(ValveStateValues))]
		VALVE_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:LOCK_STATE)}}
		/// <br/><b>Values</b>: <see cref="LockStateValues" />
		/// </summary>
		[ObservationalValue(typeof(LockStateValues))]
		LOCK_STATE,
		/// <summary>
		﻿/// {{def(EventEnum:UNLOAD_COUNT)}}
		/// <br/><b>Sub-Type</b>: <see cref="UnloadCountSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(UnloadCountSubTypes))]
		UNLOAD_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:CYCLE_COUNT)}}
		/// <br/><b>Sub-Type</b>: <see cref="CycleCountSubTypes" />
		/// </summary>
		[ObservationalSubType(typeof(CycleCountSubTypes))]
		CYCLE_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:OPERATING_MODE)}}
		/// <br/><b>Values</b>: <see cref="OperatingModeValues" />
		/// </summary>
		[ObservationalValue(typeof(OperatingModeValues))]
		OPERATING_MODE,
		/// <summary>
		﻿/// {{def(EventEnum:ASSET_COUNT)}}
		/// </summary>
		ASSET_COUNT,
		/// <summary>
		﻿/// {{def(EventEnum:MAINTENANCE_LIST)}}  If the {{property(INTERVAL)}} {{property(key)}} is not provided, it is assumed <c>ABSOLUTE</c>.  If the {{property(DIRECTION)}} {{property(key)}} is not provided, it is assumed <c>UP</c>.  If the {{property(UNITS)}} {{property(key)}} is not provided, it is assumed to be <c>COUNT</c>.
		/// </summary>
		MAINTENANCE_LIST,
		/// <summary>
		﻿/// {{def(EventEnum:FIXTURE_ID)}}
		/// </summary>
		FIXTURE_ID,
		/// <summary>
		﻿/// {{def(EventEnum:PART_COUNT_TYPE)}}
		/// <br/><b>Values</b>: <see cref="PartCountTypeValues" />
		/// </summary>
		[ObservationalValue(typeof(PartCountTypeValues))]
		PART_COUNT_TYPE,
		/// <summary>
		﻿/// {{def(EventEnum:CLOCK_TIME)}}
		/// </summary>
		CLOCK_TIME,
		/// <summary>
		﻿/// {{def(EventEnum:NETWORK_PORT)}}
		/// </summary>
		NETWORK_PORT,
		/// <summary>
		﻿/// {{def(EventEnum:HOST_NAME)}}
		/// </summary>
		HOST_NAME,
		/// <summary>
		﻿/// {{def(EventEnum:LEAK_DETECT)}}
		/// <br/><b>Values</b>: <see cref="LeakDetectValues" />
		/// </summary>
		[ObservationalValue(typeof(LeakDetectValues))]
		LEAK_DETECT,
		/// <summary>
		﻿/// {{def(EventEnum:BATTERY_STATE)}}
		/// <br/><b>Values</b>: <see cref="BatteryStateValues" />
		/// </summary>
		[ObservationalValue(typeof(BatteryStateValues))]
		BATTERY_STATE,
	}
}