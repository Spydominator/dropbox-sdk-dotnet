// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The list folders args object</para>
    /// </summary>
    public class ListFoldersArgs
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListFoldersArgs> Encoder = new ListFoldersArgsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListFoldersArgs> Decoder = new ListFoldersArgsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFoldersArgs" />
        /// class.</para>
        /// </summary>
        /// <param name="includeMembership">If include user and group membership information in
        /// the response.</param>
        public ListFoldersArgs(bool includeMembership = false)
        {
            this.IncludeMembership = includeMembership;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFoldersArgs" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ListFoldersArgs()
        {
            this.IncludeMembership = false;
        }

        /// <summary>
        /// <para>If include user and group membership information in the response.</para>
        /// </summary>
        public bool IncludeMembership { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ListFoldersArgs" />.</para>
        /// </summary>
        private class ListFoldersArgsEncoder : enc.StructEncoder<ListFoldersArgs>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListFoldersArgs value, enc.IJsonWriter writer)
            {
                WriteProperty("include_membership", value.IncludeMembership, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ListFoldersArgs" />.</para>
        /// </summary>
        private class ListFoldersArgsDecoder : enc.StructDecoder<ListFoldersArgs>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListFoldersArgs" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListFoldersArgs Create()
            {
                return new ListFoldersArgs();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ListFoldersArgs value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "include_membership":
                        value.IncludeMembership = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
