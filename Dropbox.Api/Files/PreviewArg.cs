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
    /// <para>The preview arg object</para>
    /// </summary>
    public class PreviewArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PreviewArg> Encoder = new PreviewArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PreviewArg> Decoder = new PreviewArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PreviewArg" /> class.</para>
        /// </summary>
        /// <param name="path">The path of the file to preview.</param>
        /// <param name="rev">Deprecated. Please specify revision in :field:'path'
        /// instead</param>
        public PreviewArg(string path,
                          string rev = null)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            else if (!re.Regex.IsMatch(path, @"((/|id:).*)|(rev:[0-9a-f]{9,})"))
            {
                throw new sys.ArgumentOutOfRangeException("path");
            }

            if (rev != null && (rev.Length < 9 || !re.Regex.IsMatch(rev, @"[0-9a-f]+")))
            {
                throw new sys.ArgumentOutOfRangeException("rev");
            }

            this.Path = path;
            this.Rev = rev;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PreviewArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public PreviewArg()
        {
        }

        /// <summary>
        /// <para>The path of the file to preview.</para>
        /// </summary>
        public string Path { get; protected set; }

        /// <summary>
        /// <para>Deprecated. Please specify revision in :field:'path' instead</para>
        /// </summary>
        public string Rev { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PreviewArg" />.</para>
        /// </summary>
        private class PreviewArgEncoder : enc.StructEncoder<PreviewArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PreviewArg value, enc.IJsonWriter writer)
            {
                WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
                if (value.Rev != null)
                {
                    WriteProperty("rev", value.Rev, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PreviewArg" />.</para>
        /// </summary>
        private class PreviewArgDecoder : enc.StructDecoder<PreviewArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PreviewArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PreviewArg Create()
            {
                return new PreviewArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PreviewArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "rev":
                        value.Rev = enc.StringDecoder.Instance.Decode(reader);
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
