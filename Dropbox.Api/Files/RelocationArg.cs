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
    /// <para>The relocation arg object</para>
    /// </summary>
    public class RelocationArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RelocationArg> Encoder = new RelocationArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RelocationArg> Decoder = new RelocationArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RelocationArg" /> class.</para>
        /// </summary>
        /// <param name="fromPath">Path in the user's Dropbox to be copied or moved.</param>
        /// <param name="toPath">Path in the user's Dropbox that is the destination.</param>
        public RelocationArg(string fromPath,
                             string toPath)
        {
            if (fromPath == null)
            {
                throw new sys.ArgumentNullException("fromPath");
            }
            else if (!re.Regex.IsMatch(fromPath, @"/.*"))
            {
                throw new sys.ArgumentOutOfRangeException("fromPath");
            }

            if (toPath == null)
            {
                throw new sys.ArgumentNullException("toPath");
            }
            else if (!re.Regex.IsMatch(toPath, @"/.*"))
            {
                throw new sys.ArgumentOutOfRangeException("toPath");
            }

            this.FromPath = fromPath;
            this.ToPath = toPath;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RelocationArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public RelocationArg()
        {
        }

        /// <summary>
        /// <para>Path in the user's Dropbox to be copied or moved.</para>
        /// </summary>
        public string FromPath { get; protected set; }

        /// <summary>
        /// <para>Path in the user's Dropbox that is the destination.</para>
        /// </summary>
        public string ToPath { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RelocationArg" />.</para>
        /// </summary>
        private class RelocationArgEncoder : enc.StructEncoder<RelocationArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RelocationArg value, enc.IJsonWriter writer)
            {
                WriteProperty("from_path", value.FromPath, writer, enc.StringEncoder.Instance);
                WriteProperty("to_path", value.ToPath, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RelocationArg" />.</para>
        /// </summary>
        private class RelocationArgDecoder : enc.StructDecoder<RelocationArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RelocationArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RelocationArg Create()
            {
                return new RelocationArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RelocationArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "from_path":
                        value.FromPath = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "to_path":
                        value.ToPath = enc.StringDecoder.Instance.Decode(reader);
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
