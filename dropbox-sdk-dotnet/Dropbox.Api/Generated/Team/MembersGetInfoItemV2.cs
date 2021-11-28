// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Describes a result obtained for a single user whose id was specified in the
    /// parameter of <see cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.MembersGetInfoV2Async"
    /// />.</para>
    /// </summary>
    public class MembersGetInfoItemV2
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MembersGetInfoItemV2> Encoder = new MembersGetInfoItemV2Encoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MembersGetInfoItemV2> Decoder = new MembersGetInfoItemV2Decoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MembersGetInfoItemV2" />
        /// class.</para>
        /// </summary>
        public MembersGetInfoItemV2()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MemberInfo</para>
        /// </summary>
        public bool IsMemberInfo
        {
            get
            {
                return this is MemberInfo;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MemberInfo, or <c>null</c>.</para>
        /// </summary>
        public MemberInfo AsMemberInfo
        {
            get
            {
                return this as MemberInfo;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is IdNotFound</para>
        /// </summary>
        public bool IsIdNotFound
        {
            get
            {
                return this is IdNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a IdNotFound, or <c>null</c>.</para>
        /// </summary>
        public IdNotFound AsIdNotFound
        {
            get
            {
                return this as IdNotFound;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MembersGetInfoItemV2" />.</para>
        /// </summary>
        private class MembersGetInfoItemV2Encoder : enc.StructEncoder<MembersGetInfoItemV2>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MembersGetInfoItemV2 value, enc.IJsonWriter writer)
            {
                if (value is MemberInfo)
                {
                    WriteProperty(".tag", "member_info", writer, enc.StringEncoder.Instance);
                    MemberInfo.Encoder.EncodeFields((MemberInfo)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                if (value is IdNotFound)
                {
                    WriteProperty(".tag", "id_not_found", writer, enc.StringEncoder.Instance);
                    IdNotFound.Encoder.EncodeFields((IdNotFound)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MembersGetInfoItemV2" />.</para>
        /// </summary>
        private class MembersGetInfoItemV2Decoder : enc.UnionDecoder<MembersGetInfoItemV2>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MembersGetInfoItemV2" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MembersGetInfoItemV2 Create()
            {
                return new MembersGetInfoItemV2();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override MembersGetInfoItemV2 Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "member_info":
                        return MemberInfo.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                    case "id_not_found":
                        return IdNotFound.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Info about a team member.</para>
        /// </summary>
        public sealed class MemberInfo : MembersGetInfoItemV2
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<MemberInfo> Encoder = new MemberInfoEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<MemberInfo> Decoder = new MemberInfoDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MemberInfo" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public MemberInfo(TeamMemberInfoV2 value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MemberInfo" /> class.</para>
            /// </summary>
            private MemberInfo()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public TeamMemberInfoV2 Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="MemberInfo" />.</para>
            /// </summary>
            private class MemberInfoEncoder : enc.StructEncoder<MemberInfo>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(MemberInfo value, enc.IJsonWriter writer)
                {
                    WriteProperty("member_info", value.Value, writer, global::Dropbox.Api.Team.TeamMemberInfoV2.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="MemberInfo" />.</para>
            /// </summary>
            private class MemberInfoDecoder : enc.StructDecoder<MemberInfo>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="MemberInfo" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override MemberInfo Create()
                {
                    return new MemberInfo();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override MemberInfo DecodeFields(enc.IJsonReader reader)
                {
                    return new MemberInfo(global::Dropbox.Api.Team.TeamMemberInfoV2.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : MembersGetInfoItemV2
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>An ID that was provided as a parameter to <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.MembersGetInfoAsync" /> or <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.MembersGetInfoV2Async" />, and did not
        /// match a corresponding user. This might be a team_member_id, an email, or an
        /// external ID, depending on how the method was called.</para>
        /// </summary>
        public sealed class IdNotFound : MembersGetInfoItemV2
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<IdNotFound> Encoder = new IdNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<IdNotFound> Decoder = new IdNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="IdNotFound" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public IdNotFound(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="IdNotFound" /> class.</para>
            /// </summary>
            private IdNotFound()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="IdNotFound" />.</para>
            /// </summary>
            private class IdNotFoundEncoder : enc.StructEncoder<IdNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(IdNotFound value, enc.IJsonWriter writer)
                {
                    WriteProperty("id_not_found", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="IdNotFound" />.</para>
            /// </summary>
            private class IdNotFoundDecoder : enc.StructDecoder<IdNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="IdNotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override IdNotFound Create()
                {
                    return new IdNotFound();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(IdNotFound value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "id_not_found":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
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
}