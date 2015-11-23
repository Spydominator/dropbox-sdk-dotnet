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
    /// <para>The folder metadata object</para>
    /// </summary>
    /// <seealso cref="Metadata" />
    public class FolderMetadata : Metadata
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FolderMetadata> Encoder = new FolderMetadataEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FolderMetadata> Decoder = new FolderMetadataDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FolderMetadata" /> class.</para>
        /// </summary>
        /// <param name="name">The last component of the path (including extension). This never
        /// contains a slash.</param>
        /// <param name="pathLower">The lowercased full path in the user's Dropbox. This always
        /// starts with a slash.</param>
        /// <param name="id">A unique identifier for the folder.</param>
        public FolderMetadata(string name,
                              string pathLower,
                              string id = null)
            : base(name, pathLower)
        {
            if (id != null && (id.Length < 1))
            {
                throw new sys.ArgumentOutOfRangeException("id");
            }

            this.Id = id;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FolderMetadata" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public FolderMetadata()
        {
        }

        /// <summary>
        /// <para>A unique identifier for the folder.</para>
        /// </summary>
        public string Id { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FolderMetadata" />.</para>
        /// </summary>
        private class FolderMetadataEncoder : enc.StructEncoder<FolderMetadata>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FolderMetadata value, enc.IJsonWriter writer)
            {
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                WriteProperty("path_lower", value.PathLower, writer, enc.StringEncoder.Instance);
                if (value.Id != null)
                {
                    WriteProperty("id", value.Id, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FolderMetadata" />.</para>
        /// </summary>
        private class FolderMetadataDecoder : enc.StructDecoder<FolderMetadata>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FolderMetadata" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FolderMetadata Create()
            {
                return new FolderMetadata();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FolderMetadata value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "path_lower":
                        value.PathLower = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "id":
                        value.Id = enc.StringDecoder.Instance.Decode(reader);
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
