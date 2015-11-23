// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Indicates that there used to be a file or folder at this path, but it no longer
    /// exists.</para>
    /// </summary>
    /// <seealso cref="Metadata" />
    public class DeletedMetadata : Metadata
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeletedMetadata> Encoder = new DeletedMetadataEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeletedMetadata> Decoder = new DeletedMetadataDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeletedMetadata" />
        /// class.</para>
        /// </summary>
        /// <param name="name">The last component of the path (including extension). This never
        /// contains a slash.</param>
        /// <param name="pathLower">The lowercased full path in the user's Dropbox. This always
        /// starts with a slash.</param>
        public DeletedMetadata(string name,
                               string pathLower)
            : base(name, pathLower)
        {
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeletedMetadata" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public DeletedMetadata()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DeletedMetadata" />.</para>
        /// </summary>
        private class DeletedMetadataEncoder : enc.StructEncoder<DeletedMetadata>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeletedMetadata value, enc.IJsonWriter writer)
            {
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                WriteProperty("path_lower", value.PathLower, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DeletedMetadata" />.</para>
        /// </summary>
        private class DeletedMetadataDecoder : enc.StructDecoder<DeletedMetadata>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DeletedMetadata" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeletedMetadata Create()
            {
                return new DeletedMetadata();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DeletedMetadata value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "path_lower":
                        value.PathLower = enc.StringDecoder.Instance.Decode(reader);
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
