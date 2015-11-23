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
    /// <para>If any of the policy's are unset, then they retain their current setting.</para>
    /// </summary>
    public class UpdateFolderPolicyArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UpdateFolderPolicyArg> Encoder = new UpdateFolderPolicyArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UpdateFolderPolicyArg> Decoder = new UpdateFolderPolicyArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UpdateFolderPolicyArg" />
        /// class.</para>
        /// </summary>
        /// <param name="sharedFolderId">The ID for the shared folder.</param>
        /// <param name="memberPolicy">Who can be a member of this shared folder. Only set this
        /// if the current user is on a team.</param>
        /// <param name="aclUpdatePolicy">Who can add and remove members of this shared
        /// folder.</param>
        /// <param name="sharedLinkPolicy">The policy to apply to shared links created for
        /// content inside this shared folder.</param>
        public UpdateFolderPolicyArg(string sharedFolderId,
                                     MemberPolicy memberPolicy = null,
                                     AclUpdatePolicy aclUpdatePolicy = null,
                                     SharedLinkPolicy sharedLinkPolicy = null)
        {
            if (sharedFolderId == null)
            {
                throw new sys.ArgumentNullException("sharedFolderId");
            }
            else if (!re.Regex.IsMatch(sharedFolderId, @"[-_0-9a-zA-Z]+"))
            {
                throw new sys.ArgumentOutOfRangeException("sharedFolderId");
            }

            this.SharedFolderId = sharedFolderId;
            this.MemberPolicy = memberPolicy;
            this.AclUpdatePolicy = aclUpdatePolicy;
            this.SharedLinkPolicy = sharedLinkPolicy;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UpdateFolderPolicyArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public UpdateFolderPolicyArg()
        {
        }

        /// <summary>
        /// <para>The ID for the shared folder.</para>
        /// </summary>
        public string SharedFolderId { get; protected set; }

        /// <summary>
        /// <para>Who can be a member of this shared folder. Only set this if the current user
        /// is on a team.</para>
        /// </summary>
        public MemberPolicy MemberPolicy { get; protected set; }

        /// <summary>
        /// <para>Who can add and remove members of this shared folder.</para>
        /// </summary>
        public AclUpdatePolicy AclUpdatePolicy { get; protected set; }

        /// <summary>
        /// <para>The policy to apply to shared links created for content inside this shared
        /// folder.</para>
        /// </summary>
        public SharedLinkPolicy SharedLinkPolicy { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UpdateFolderPolicyArg" />.</para>
        /// </summary>
        private class UpdateFolderPolicyArgEncoder : enc.StructEncoder<UpdateFolderPolicyArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UpdateFolderPolicyArg value, enc.IJsonWriter writer)
            {
                WriteProperty("shared_folder_id", value.SharedFolderId, writer, enc.StringEncoder.Instance);
                if (value.MemberPolicy != null)
                {
                    WriteProperty("member_policy", value.MemberPolicy, writer, MemberPolicy.Encoder);
                }
                if (value.AclUpdatePolicy != null)
                {
                    WriteProperty("acl_update_policy", value.AclUpdatePolicy, writer, AclUpdatePolicy.Encoder);
                }
                if (value.SharedLinkPolicy != null)
                {
                    WriteProperty("shared_link_policy", value.SharedLinkPolicy, writer, SharedLinkPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UpdateFolderPolicyArg" />.</para>
        /// </summary>
        private class UpdateFolderPolicyArgDecoder : enc.StructDecoder<UpdateFolderPolicyArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UpdateFolderPolicyArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UpdateFolderPolicyArg Create()
            {
                return new UpdateFolderPolicyArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UpdateFolderPolicyArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "shared_folder_id":
                        value.SharedFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member_policy":
                        value.MemberPolicy = MemberPolicy.Decoder.Decode(reader);
                        break;
                    case "acl_update_policy":
                        value.AclUpdatePolicy = AclUpdatePolicy.Decoder.Decode(reader);
                        break;
                    case "shared_link_policy":
                        value.SharedLinkPolicy = SharedLinkPolicy.Decoder.Decode(reader);
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
