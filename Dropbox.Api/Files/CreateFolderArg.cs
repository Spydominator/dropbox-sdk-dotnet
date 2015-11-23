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
    /// <para>The create folder arg object</para>
    /// </summary>
    public class CreateFolderArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<CreateFolderArg> Encoder = new CreateFolderArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<CreateFolderArg> Decoder = new CreateFolderArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CreateFolderArg" />
        /// class.</para>
        /// </summary>
        /// <param name="path">Path in the user's Dropbox to create.</param>
        public CreateFolderArg(string path)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            else if (!re.Regex.IsMatch(path, @"/.*"))
            {
                throw new sys.ArgumentOutOfRangeException("path");
            }

            this.Path = path;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CreateFolderArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public CreateFolderArg()
        {
        }

        /// <summary>
        /// <para>Path in the user's Dropbox to create.</para>
        /// </summary>
        public string Path { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="CreateFolderArg" />.</para>
        /// </summary>
        private class CreateFolderArgEncoder : enc.StructEncoder<CreateFolderArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(CreateFolderArg value, enc.IJsonWriter writer)
            {
                WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="CreateFolderArg" />.</para>
        /// </summary>
        private class CreateFolderArgDecoder : enc.StructDecoder<CreateFolderArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="CreateFolderArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override CreateFolderArg Create()
            {
                return new CreateFolderArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(CreateFolderArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
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
