using System;

using F10Y.T0000;


namespace F10Y.T0003
{
    /// <summary>
    /// Attribute indicating an interface contains value instances. (i.e. properties on an interface).
    /// </summary>
    /// <remarks>
    /// <para>Values interface names should be <b>plural</b>. This is so "IString" and "String" does not class with "String" from system.</para>
    /// <para>Values can be implemented as arrow-expressions on an interface (interface default methods).</para>
    /// The marker attribute is useful for surveying value interfaces and building a catalogue of values.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface, // Values are always properties on an interface.
        AllowMultiple = false, // No.
        Inherited = false // Make the inheritor also use the marker.
    )]
    [MarkerAttributeMarker]
    public class ValuesMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that an interface is *not* a values interface.
        /// This is useful for marking interfaces that end up canonical values code file locations, but are not values interfaces.
        /// </summary>
        public bool Is_Values { get; }


        public ValuesMarkerAttribute(
            bool is_Values = true)
        {
            this.Is_Values = is_Values;
        }
    }
}
