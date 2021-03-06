// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.FileProperties
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The update template result object</para>
    /// </summary>
    public class UpdateTemplateResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UpdateTemplateResult> Encoder = new UpdateTemplateResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UpdateTemplateResult> Decoder = new UpdateTemplateResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UpdateTemplateResult" />
        /// class.</para>
        /// </summary>
        /// <param name="templateId">An identifier for template added by route  See <see
        /// cref="Dropbox.Api.FileProperties.Routes.FilePropertiesUserRoutes.TemplatesAddForUserAsync"
        /// /> or <see
        /// cref="Dropbox.Api.FileProperties.Routes.FilePropertiesTeamRoutes.TemplatesAddForTeamAsync"
        /// />.</param>
        public UpdateTemplateResult(string templateId)
        {
            if (templateId == null)
            {
                throw new sys.ArgumentNullException("templateId");
            }
            if (templateId.Length < 1)
            {
                throw new sys.ArgumentOutOfRangeException("templateId", "Length should be at least 1");
            }
            if (!re.Regex.IsMatch(templateId, @"\A(?:(/|ptid:).*)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("templateId", @"Value should match pattern '\A(?:(/|ptid:).*)\z'");
            }

            this.TemplateId = templateId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UpdateTemplateResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UpdateTemplateResult()
        {
        }

        /// <summary>
        /// <para>An identifier for template added by route  See <see
        /// cref="Dropbox.Api.FileProperties.Routes.FilePropertiesUserRoutes.TemplatesAddForUserAsync"
        /// /> or <see
        /// cref="Dropbox.Api.FileProperties.Routes.FilePropertiesTeamRoutes.TemplatesAddForTeamAsync"
        /// />.</para>
        /// </summary>
        public string TemplateId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UpdateTemplateResult" />.</para>
        /// </summary>
        private class UpdateTemplateResultEncoder : enc.StructEncoder<UpdateTemplateResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UpdateTemplateResult value, enc.IJsonWriter writer)
            {
                WriteProperty("template_id", value.TemplateId, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UpdateTemplateResult" />.</para>
        /// </summary>
        private class UpdateTemplateResultDecoder : enc.StructDecoder<UpdateTemplateResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UpdateTemplateResult" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UpdateTemplateResult Create()
            {
                return new UpdateTemplateResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UpdateTemplateResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "template_id":
                        value.TemplateId = enc.StringDecoder.Instance.Decode(reader);
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
