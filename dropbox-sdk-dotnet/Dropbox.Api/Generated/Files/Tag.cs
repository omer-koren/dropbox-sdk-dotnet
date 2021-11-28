// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Tag that can be added in multiple ways.</para>
    /// </summary>
    public class Tag
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<Tag> Encoder = new TagEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<Tag> Decoder = new TagDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Tag" /> class.</para>
        /// </summary>
        public Tag()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UserGeneratedTag</para>
        /// </summary>
        public bool IsUserGeneratedTag
        {
            get
            {
                return this is UserGeneratedTag;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UserGeneratedTag, or <c>null</c>.</para>
        /// </summary>
        public UserGeneratedTag AsUserGeneratedTag
        {
            get
            {
                return this as UserGeneratedTag;
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

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="Tag" />.</para>
        /// </summary>
        private class TagEncoder : enc.StructEncoder<Tag>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(Tag value, enc.IJsonWriter writer)
            {
                if (value is UserGeneratedTag)
                {
                    WriteProperty(".tag", "user_generated_tag", writer, enc.StringEncoder.Instance);
                    UserGeneratedTag.Encoder.EncodeFields((UserGeneratedTag)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="Tag" />.</para>
        /// </summary>
        private class TagDecoder : enc.UnionDecoder<Tag>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="Tag" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override Tag Create()
            {
                return new Tag();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override Tag Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "user_generated_tag":
                        return UserGeneratedTag.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Tag generated by the user.</para>
        /// </summary>
        public sealed class UserGeneratedTag : Tag
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UserGeneratedTag> Encoder = new UserGeneratedTagEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UserGeneratedTag> Decoder = new UserGeneratedTagDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UserGeneratedTag" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public UserGeneratedTag(global::Dropbox.Api.Files.UserGeneratedTag value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UserGeneratedTag" />
            /// class.</para>
            /// </summary>
            private UserGeneratedTag()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public global::Dropbox.Api.Files.UserGeneratedTag Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UserGeneratedTag" />.</para>
            /// </summary>
            private class UserGeneratedTagEncoder : enc.StructEncoder<UserGeneratedTag>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UserGeneratedTag value, enc.IJsonWriter writer)
                {
                    WriteProperty("user_generated_tag", value.Value, writer, global::Dropbox.Api.Files.UserGeneratedTag.Encoder);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UserGeneratedTag" />.</para>
            /// </summary>
            private class UserGeneratedTagDecoder : enc.StructDecoder<UserGeneratedTag>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UserGeneratedTag" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UserGeneratedTag Create()
                {
                    return new UserGeneratedTag();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override UserGeneratedTag DecodeFields(enc.IJsonReader reader)
                {
                    return new UserGeneratedTag(global::Dropbox.Api.Files.UserGeneratedTag.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : Tag
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
    }
}