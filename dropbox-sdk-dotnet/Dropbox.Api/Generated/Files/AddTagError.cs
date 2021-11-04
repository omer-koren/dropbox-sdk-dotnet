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
    /// <para>The add tag error object</para>
    /// </summary>
    public class AddTagError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AddTagError> Encoder = new AddTagErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AddTagError> Decoder = new AddTagErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AddTagError" /> class.</para>
        /// </summary>
        public AddTagError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is TooManyTags</para>
        /// </summary>
        public bool IsTooManyTags
        {
            get
            {
                return this is TooManyTags;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TooManyTags, or <c>null</c>.</para>
        /// </summary>
        public TooManyTags AsTooManyTags
        {
            get
            {
                return this as TooManyTags;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is FeatureNotSupported</para>
        /// </summary>
        public bool IsFeatureNotSupported
        {
            get
            {
                return this is FeatureNotSupported;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a FeatureNotSupported, or <c>null</c>.</para>
        /// </summary>
        public FeatureNotSupported AsFeatureNotSupported
        {
            get
            {
                return this as FeatureNotSupported;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is PathNotFound</para>
        /// </summary>
        public bool IsPathNotFound
        {
            get
            {
                return this is PathNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PathNotFound, or <c>null</c>.</para>
        /// </summary>
        public PathNotFound AsPathNotFound
        {
            get
            {
                return this as PathNotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Unknown</para>
        /// </summary>
        public bool IsUnknown
        {
            get
            {
                return this is Unknown;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Unknown, or <c>null</c>.</para>
        /// </summary>
        public Unknown AsUnknown
        {
            get
            {
                return this as Unknown;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Transient</para>
        /// </summary>
        public bool IsTransient
        {
            get
            {
                return this is Transient;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Transient, or <c>null</c>.</para>
        /// </summary>
        public Transient AsTransient
        {
            get
            {
                return this as Transient;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InputValidation</para>
        /// </summary>
        public bool IsInputValidation
        {
            get
            {
                return this is InputValidation;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InputValidation, or <c>null</c>.</para>
        /// </summary>
        public InputValidation AsInputValidation
        {
            get
            {
                return this as InputValidation;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Cancelled</para>
        /// </summary>
        public bool IsCancelled
        {
            get
            {
                return this is Cancelled;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Cancelled, or <c>null</c>.</para>
        /// </summary>
        public Cancelled AsCancelled
        {
            get
            {
                return this as Cancelled;
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
        /// <para>Encoder for  <see cref="AddTagError" />.</para>
        /// </summary>
        private class AddTagErrorEncoder : enc.StructEncoder<AddTagError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AddTagError value, enc.IJsonWriter writer)
            {
                if (value is TooManyTags)
                {
                    WriteProperty(".tag", "too_many_tags", writer, enc.StringEncoder.Instance);
                    TooManyTags.Encoder.EncodeFields((TooManyTags)value, writer);
                    return;
                }
                if (value is FeatureNotSupported)
                {
                    WriteProperty(".tag", "feature_not_supported", writer, enc.StringEncoder.Instance);
                    FeatureNotSupported.Encoder.EncodeFields((FeatureNotSupported)value, writer);
                    return;
                }
                if (value is PathNotFound)
                {
                    WriteProperty(".tag", "path_not_found", writer, enc.StringEncoder.Instance);
                    PathNotFound.Encoder.EncodeFields((PathNotFound)value, writer);
                    return;
                }
                if (value is Unknown)
                {
                    WriteProperty(".tag", "unknown", writer, enc.StringEncoder.Instance);
                    Unknown.Encoder.EncodeFields((Unknown)value, writer);
                    return;
                }
                if (value is Transient)
                {
                    WriteProperty(".tag", "transient", writer, enc.StringEncoder.Instance);
                    Transient.Encoder.EncodeFields((Transient)value, writer);
                    return;
                }
                if (value is InputValidation)
                {
                    WriteProperty(".tag", "input_validation", writer, enc.StringEncoder.Instance);
                    InputValidation.Encoder.EncodeFields((InputValidation)value, writer);
                    return;
                }
                if (value is Cancelled)
                {
                    WriteProperty(".tag", "cancelled", writer, enc.StringEncoder.Instance);
                    Cancelled.Encoder.EncodeFields((Cancelled)value, writer);
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
        /// <para>Decoder for  <see cref="AddTagError" />.</para>
        /// </summary>
        private class AddTagErrorDecoder : enc.UnionDecoder<AddTagError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AddTagError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AddTagError Create()
            {
                return new AddTagError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override AddTagError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "too_many_tags":
                        return TooManyTags.Decoder.DecodeFields(reader);
                    case "feature_not_supported":
                        return FeatureNotSupported.Decoder.DecodeFields(reader);
                    case "path_not_found":
                        return PathNotFound.Decoder.DecodeFields(reader);
                    case "unknown":
                        return Unknown.Decoder.DecodeFields(reader);
                    case "transient":
                        return Transient.Decoder.DecodeFields(reader);
                    case "input_validation":
                        return InputValidation.Decoder.DecodeFields(reader);
                    case "cancelled":
                        return Cancelled.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Item already has max supported tags.</para>
        /// </summary>
        public sealed class TooManyTags : AddTagError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TooManyTags> Encoder = new TooManyTagsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TooManyTags> Decoder = new TooManyTagsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="TooManyTags" />
            /// class.</para>
            /// </summary>
            private TooManyTags()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TooManyTags</para>
            /// </summary>
            public static readonly TooManyTags Instance = new TooManyTags();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TooManyTags" />.</para>
            /// </summary>
            private class TooManyTagsEncoder : enc.StructEncoder<TooManyTags>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TooManyTags value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TooManyTags" />.</para>
            /// </summary>
            private class TooManyTagsDecoder : enc.StructDecoder<TooManyTags>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="TooManyTags" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TooManyTags Create()
                {
                    return TooManyTags.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Tags are not turned on for your team. Please turn on the feature.</para>
        /// </summary>
        public sealed class FeatureNotSupported : AddTagError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<FeatureNotSupported> Encoder = new FeatureNotSupportedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<FeatureNotSupported> Decoder = new FeatureNotSupportedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="FeatureNotSupported" />
            /// class.</para>
            /// </summary>
            private FeatureNotSupported()
            {
            }

            /// <summary>
            /// <para>A singleton instance of FeatureNotSupported</para>
            /// </summary>
            public static readonly FeatureNotSupported Instance = new FeatureNotSupported();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="FeatureNotSupported" />.</para>
            /// </summary>
            private class FeatureNotSupportedEncoder : enc.StructEncoder<FeatureNotSupported>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(FeatureNotSupported value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="FeatureNotSupported" />.</para>
            /// </summary>
            private class FeatureNotSupportedDecoder : enc.StructDecoder<FeatureNotSupported>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="FeatureNotSupported"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override FeatureNotSupported Create()
                {
                    return FeatureNotSupported.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Path not found.</para>
        /// </summary>
        public sealed class PathNotFound : AddTagError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PathNotFound> Encoder = new PathNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PathNotFound> Decoder = new PathNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PathNotFound" />
            /// class.</para>
            /// </summary>
            private PathNotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of PathNotFound</para>
            /// </summary>
            public static readonly PathNotFound Instance = new PathNotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PathNotFound" />.</para>
            /// </summary>
            private class PathNotFoundEncoder : enc.StructEncoder<PathNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PathNotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PathNotFound" />.</para>
            /// </summary>
            private class PathNotFoundDecoder : enc.StructDecoder<PathNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="PathNotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PathNotFound Create()
                {
                    return PathNotFound.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Action failed.</para>
        /// </summary>
        public sealed class Unknown : AddTagError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Unknown> Encoder = new UnknownEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Unknown> Decoder = new UnknownDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Unknown" /> class.</para>
            /// </summary>
            private Unknown()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Unknown</para>
            /// </summary>
            public static readonly Unknown Instance = new Unknown();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Unknown" />.</para>
            /// </summary>
            private class UnknownEncoder : enc.StructEncoder<Unknown>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Unknown value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Unknown" />.</para>
            /// </summary>
            private class UnknownDecoder : enc.StructDecoder<Unknown>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Unknown" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Unknown Create()
                {
                    return Unknown.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Action failed. Try again.</para>
        /// </summary>
        public sealed class Transient : AddTagError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Transient> Encoder = new TransientEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Transient> Decoder = new TransientDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Transient" /> class.</para>
            /// </summary>
            private Transient()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Transient</para>
            /// </summary>
            public static readonly Transient Instance = new Transient();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Transient" />.</para>
            /// </summary>
            private class TransientEncoder : enc.StructEncoder<Transient>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Transient value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Transient" />.</para>
            /// </summary>
            private class TransientDecoder : enc.StructDecoder<Transient>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Transient" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Transient Create()
                {
                    return Transient.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Action failed due to wrong params.</para>
        /// </summary>
        public sealed class InputValidation : AddTagError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InputValidation> Encoder = new InputValidationEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InputValidation> Decoder = new InputValidationDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InputValidation" />
            /// class.</para>
            /// </summary>
            private InputValidation()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InputValidation</para>
            /// </summary>
            public static readonly InputValidation Instance = new InputValidation();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InputValidation" />.</para>
            /// </summary>
            private class InputValidationEncoder : enc.StructEncoder<InputValidation>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InputValidation value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InputValidation" />.</para>
            /// </summary>
            private class InputValidationDecoder : enc.StructDecoder<InputValidation>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InputValidation" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InputValidation Create()
                {
                    return InputValidation.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Action cancelled.</para>
        /// </summary>
        public sealed class Cancelled : AddTagError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Cancelled> Encoder = new CancelledEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Cancelled> Decoder = new CancelledDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Cancelled" /> class.</para>
            /// </summary>
            private Cancelled()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Cancelled</para>
            /// </summary>
            public static readonly Cancelled Instance = new Cancelled();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Cancelled" />.</para>
            /// </summary>
            private class CancelledEncoder : enc.StructEncoder<Cancelled>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Cancelled value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Cancelled" />.</para>
            /// </summary>
            private class CancelledDecoder : enc.StructDecoder<Cancelled>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Cancelled" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Cancelled Create()
                {
                    return Cancelled.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : AddTagError
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
