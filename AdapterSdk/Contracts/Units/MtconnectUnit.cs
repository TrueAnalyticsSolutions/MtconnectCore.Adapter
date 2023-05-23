#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;
using Mtconnect.AdapterSdk.Contracts;
using Mtconnect.AdapterSdk.Contracts.Attributes;

namespace Mtconnect.AdapterSdk.Units
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_8FEC81E4_8E1F_4f45_820B_F9F25DD83F9A">model.mtconnect.org</seealso>
	﻿	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp.Adapter", "1.0.12.0")]
	public enum MtconnectUnit
	{
		/// <summary>
		/// An extension to the standard. Extensions to the standard are usually prefaced with <c>x:</c>.
		/// </summary>
		STANDARD_EXTENSION = -1,
		/// <summary>
		﻿/// amps.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		AMPERE,
		/// <summary>
		﻿/// degrees Celsius.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		CELSIUS,
		/// <summary>
		﻿/// count of something.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		COUNT,
		/// <summary>
		﻿/// sound level.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		DECIBEL,
		/// <summary>
		﻿/// angle in degrees.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		DEGREE,
		/// <summary>
		﻿/// space-delimited, floating-point representation of the angular rotation in degrees around the X, Y, and Z axes relative to a cartesian coordinate system respectively in order as A, B, and C.   If any of the rotations is not known, it <b>MUST</b> be zero (0).
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		DEGREE_3D,
		/// <summary>
		﻿/// angular degrees per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		DEGREE_PER_SECOND,
		/// <summary>
		﻿/// angular acceleration in degrees per second squared.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		DEGREE_PER_SECOND_SQUARED,
		/// <summary>
		﻿/// frequency measured in cycles per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		HERTZ,
		/// <summary>
		﻿/// measurement of energy.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		JOULE,
		/// <summary>
		﻿/// kilograms.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		KILOGRAM,
		/// <summary>
		﻿/// measurement of volume of a fluid.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		LITER,
		/// <summary>
		﻿/// liters per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		LITER_PER_SECOND,
		/// <summary>
		﻿/// measurement of tilt.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		MICRO_RADIAN,
		/// <summary>
		﻿/// millimeters.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		MILLIMETER,
		/// <summary>
		﻿/// point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in millimeters.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		MILLIMETER_3D,
		/// <summary>
		﻿/// millimeters per revolution.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		MILLIMETER_PER_REVOLUTION,
		/// <summary>
		﻿/// millimeters per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		MILLIMETER_PER_SECOND,
		/// <summary>
		﻿/// acceleration in millimeters per second squared.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		MILLIMETER_PER_SECOND_SQUARED,
		/// <summary>
		﻿/// force in Newtons.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		NEWTON,
		/// <summary>
		﻿/// torque, a unit for force times distance.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		NEWTON_METER,
		/// <summary>
		﻿/// measure of electrical resistance.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		OHM,
		/// <summary>
		﻿/// pressure in Newtons per square meter.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		PASCAL,
		/// <summary>
		﻿/// measurement of viscosity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		PASCAL_SECOND,
		/// <summary>
		﻿/// percentage.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		PERCENT,
		/// <summary>
		﻿/// measure of the acidity or alkalinity of a solution.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		PH,
		/// <summary>
		﻿/// revolutions per minute.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		REVOLUTION_PER_MINUTE,
		/// <summary>
		﻿/// measurement of time.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		SECOND,
		/// <summary>
		﻿/// measurement of electrical conductivity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		SIEMENS_PER_METER,
		/// <summary>
		﻿/// volts.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		VOLT,
		/// <summary>
		﻿/// measurement of the apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		VOLT_AMPERE,
		/// <summary>
		﻿/// measurement of reactive power in an AC electrical circuit (commonly referred to as VAR).
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		VOLT_AMPERE_REACTIVE,
		/// <summary>
		﻿/// watts.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_0_1, "https://model.mtconnect.org/#_Version_1.0")]
		WATT,
		/// <summary>
		﻿/// measurement of electrical energy, equal to one Joule.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		WATT_SECOND,
		/// <summary>
		﻿/// gram per cubic meter.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		GRAM_PER_CUBIC_METER,
		/// <summary>
		﻿/// geometric volume in millimeters.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		CUBIC_MILLIMETER,
		/// <summary>
		﻿/// change of geometric volume per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		CUBIC_MILLIMETER_PER_SECOND,
		/// <summary>
		﻿/// change in geometric volume per second squared.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		CUBIC_MILLIMETER_PER_SECOND_SQUARED,
		/// <summary>
		﻿/// milligram.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		MILLIGRAM,
		/// <summary>
		﻿/// milligram per cubic millimeter.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		MILLIGRAM_PER_CUBIC_MILLIMETER,
		/// <summary>
		﻿/// milliliter.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_5_0, "https://model.mtconnect.org/#_Version_1.5")]
		MILLILITER,
		/// <summary>
		﻿/// counts per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		COUNT_PER_SECOND,
		/// <summary>
		﻿/// pascal per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		PASCAL_PER_SECOND,
		/// <summary>
		﻿/// 3D Unit Vector.  Space delimited list of three floating point numbers.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_7_0, "https://model.mtconnect.org/#_Version_1.7")]
		UNIT_VECTOR_3D,
		/// <summary>
		﻿/// revolutions per second squared.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_6_0, "https://model.mtconnect.org/#_Version_1.6")]
		REVOLUTION_PER_SECOND_SQUARED,
		/// <summary>
		﻿/// rotational velocity in revolution per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_1_0, "https://model.mtconnect.org/#_Version_1.1")]
		REVOLUTION_PER_SECOND,
		/// <summary>
		﻿/// gram.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_1_2_0, "https://model.mtconnect.org/#_Version_1.2")]
		GRAM,
		/// <summary>
		﻿/// acceleration in meters per second squared.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		[MtconnectVersion(MtconnectVersions.V_2_1_0, "https://model.mtconnect.org/#_Version_2.1")]
		METER_PER_SECOND_SQUARED,
		/// <summary>
		﻿/// electric charge in coulombs (C).
		/// </summary>
		
		COULOMB,
	}
}