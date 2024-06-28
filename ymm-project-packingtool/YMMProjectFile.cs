using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ymm_project_packingtool
{
    // Powered by Visual Studio

    class YMMProjectFile
    {
        public string FilePath { get; set; }
        public Timelines Timeline { get; set; }
        public Character[] Characters { get; set; }
        public object[] CollapsedGroups { get; set; }

        public class Timelines
        {
            public Videoinfo VideoInfo { get; set; }
            public Verticalline VerticalLine { get; set; }
            public Item[] Items { get; set; }
            public Layersettings LayerSettings { get; set; }
            public int CurrentFrame { get; set; }
            public int Length { get; set; }
            public int MaxLayer { get; set; }
        }

        public class Videoinfo
        {
            public int FPS { get; set; }
            public int Hz { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }

        public class Verticalline
        {
            public bool IsEnabled { get; set; }
            public int StartFrame { get; set; }
            public string LineType { get; set; }
            public Line Line { get; set; }
            public int Group { get; set; }
        }

        public class Line
        {
            [JsonPropertyName("$type")]
            public string type { get; set; }
            public int Frame { get; set; }
        }

        public class Layersettings
        {
            public object[] Items { get; set; }
        }

        public class Item
        {
            [JsonPropertyName("$type")]
            public string type { get; set; }
            public string Text { get; set; }
            public object[] Decorations { get; set; }
            public string Font { get; set; }
            public Fontsize FontSize { get; set; }
            public Lineheight2 LineHeight2 { get; set; }
            public Letterspacing2 LetterSpacing2 { get; set; }
            public float DisplayInterval { get; set; }
            public string WordWrap { get; set; }
            public Maxwidth MaxWidth { get; set; }
            public string BasePoint { get; set; }
            public string FontColor { get; set; }
            public string Style { get; set; }
            public string StyleColor { get; set; }
            public bool Bold { get; set; }
            public bool Italic { get; set; }
            public bool IsTrimEndSpace { get; set; }
            public bool IsDevidedPerCharacter { get; set; }
            public X X { get; set; }
            public Y Y { get; set; }
            public Z Z { get; set; }
            public Opacity Opacity { get; set; }
            public Zoom Zoom { get; set; }
            public Rotation Rotation { get; set; }
            public float FadeIn { get; set; }
            public float FadeOut { get; set; }
            public string Blend { get; set; }
            public bool IsInverted { get; set; }
            public bool IsClippingWithObjectAbove { get; set; }
            public bool IsAlwaysOnTop { get; set; }
            public bool IsZOrderEnabled { get; set; }
            public object[] VideoEffects { get; set; }
            public int Group { get; set; }
            public int Frame { get; set; }
            public int Layer { get; set; }
            public Keyframes KeyFrames { get; set; }
            public int Length { get; set; }
            public float PlaybackRate { get; set; }
            public string ContentOffset { get; set; }
            public string Remark { get; set; }
            public bool IsLocked { get; set; }
            public bool IsHidden { get; set; }
            public bool IsWaveformEnabled { get; set; }
            public string FilePath { get; set; }
            public int AudioTrackIndex { get; set; }
            public Volume Volume { get; set; }
            public Pan Pan { get; set; }
            public bool IsLooped { get; set; }
            public bool EchoIsEnabled { get; set; }
            public float EchoInterval { get; set; }
            public float EchoAttenuation { get; set; }
            public object[] AudioEffects { get; set; }
            public string CharacterName { get; set; }
            public string Serif { get; set; }
            public string Hatsuon { get; set; }
            public Pronounce Pronounce { get; set; }
            public string VoiceLength { get; set; }
            public string VoiceCache { get; set; }
            public Voiceparameter VoiceParameter { get; set; }
            public float VoiceFadeIn { get; set; }
            public float VoiceFadeOut { get; set; }
            public string JimakuVisibility { get; set; }
            public float JimakuFadeIn { get; set; }
            public float JimakuFadeOut { get; set; }
            public object[] JimakuVideoEffects { get; set; }
            public Tachiefaceparameter TachieFaceParameter { get; set; }
            public object[] TachieFaceEffects { get; set; }
            public string ShapeType2 { get; set; }
            public Shapeparameter ShapeParameter { get; set; }
            public Tachieitemparameter TachieItemParameter { get; set; }
            public Blur Blur { get; set; }
            public bool InvertMask { get; set; }
            public string TransitionType { get; set; }
            public Transitionparameter TransitionParameter { get; set; }
            public object[] BeforeVideoEffects { get; set; }
            public object[] AfterVideoEffects { get; set; }
            public bool ClearBackground { get; set; }
            public bool IsAlphaEnabled { get; set; }
            public bool IsFrameOutImageRenderingEnabled { get; set; }
            public int GroupRange { get; set; }
            public bool IsGroupOnly { get; set; }
            public bool IsCompressFrame { get; set; }
            public string CompositeCenter { get; set; }
        }

        public class Fontsize
        {
            public Value[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value
        {
            [System.Text.Json.Serialization.JsonPropertyName("Value")]
            public float Values { get; set; }
        }

        public class Lineheight2
        {
            public Value1[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value1
        {
            public float Value { get; set; }
        }

        public class Letterspacing2
        {
            public Value2[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value2
        {
            public float Value { get; set; }
        }

        public class Maxwidth
        {
            public Value3[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value3
        {
            public float Value { get; set; }
        }

        public class X
        {
            public Value4[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value4
        {
            public float Value { get; set; }
        }

        public class Y
        {
            public Value5[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value5
        {
            public float Value { get; set; }
        }

        public class Z
        {
            public Value6[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value6
        {
            public float Value { get; set; }
        }

        public class Opacity
        {
            public Value7[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value7
        {
            public float Value { get; set; }
        }

        public class Zoom
        {
            public Value8[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value8
        {
            public float Value { get; set; }
        }

        public class Rotation
        {
            public Value9[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value9
        {
            public float Value { get; set; }
        }

        public class Keyframes
        {
            public object[] Frames { get; set; }
            public int Count { get; set; }
        }

        public class Volume
        {
            public Value10[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value10
        {
            public float Value { get; set; }
        }

        public class Pan
        {
            public Value11[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value11
        {
            public float Value { get; set; }
        }

        public class Pronounce
        {
            [JsonPropertyName("$type")]
            public string type { get; set; }
        }

        public class Voiceparameter
        {
            [JsonPropertyName("$type")]
            public string type { get; set; }
            public int Speed { get; set; }
        }

        public class Tachiefaceparameter
        {
            [JsonPropertyName("$type")]
            public string type { get; set; }
            public string EyeAnimation { get; set; }
            public string MouthAnimation { get; set; }
            public object Eyebrow { get; set; }
            public object Eye { get; set; }
            public object Mouth { get; set; }
            public object Hair { get; set; }
            public object Complexion { get; set; }
            public object Body { get; set; }
            public object Back1 { get; set; }
            public object Back2 { get; set; }
            public object Back3 { get; set; }
            public object Etc1 { get; set; }
            public object Etc2 { get; set; }
            public object Etc3 { get; set; }
        }

        public class Shapeparameter
        {
            [JsonPropertyName("$type")]
            public string type { get; set; }
            public Round Round { get; set; }
            public string SizeMode { get; set; }
            public Size Size { get; set; }
            public Aspectrate AspectRate { get; set; }
            public Width Width { get; set; }
            public Height Height { get; set; }
            public Strokethickness StrokeThickness { get; set; }
            public Brush Brush { get; set; }
        }

        public class Round
        {
            public Value12[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value12
        {
            public float Value { get; set; }
        }

        public class Size
        {
            public Value13[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value13
        {
            public float Value { get; set; }
        }

        public class Aspectrate
        {
            public Value14[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value14
        {
            public float Value { get; set; }
        }

        public class Width
        {
            public Value15[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value15
        {
            public float Value { get; set; }
        }

        public class Height
        {
            public Value16[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value16
        {
            public float Value { get; set; }
        }

        public class Strokethickness
        {
            public Value17[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value17
        {
            public float Value { get; set; }
        }

        public class Brush
        {
            [JsonPropertyName("$type")]
            public string Type { get; set; }
            public Parameter Parameter { get; set; }
        }

        public class Parameter
        {
            [JsonPropertyName("$type")]
            public string type { get; set; }
            public string Color { get; set; }
        }

        public class Tachieitemparameter
        {
            [JsonPropertyName("$type")]
            public string type { get; set; }
            public bool IsHiddenWhenNoSpeech { get; set; }
            public string Eyebrow { get; set; }
            public string Eye { get; set; }
            public string Mouth { get; set; }
            public string Hair { get; set; }
            public object Complexion { get; set; }
            public string Body { get; set; }
            public object Back1 { get; set; }
            public object Back2 { get; set; }
            public object Back3 { get; set; }
            public object Etc1 { get; set; }
            public object Etc2 { get; set; }
            public object Etc3 { get; set; }
        }

        public class Blur
        {
            public Value18[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value18
        {
            public float Value { get; set; }
        }

        public class Transitionparameter
        {
            [JsonPropertyName("$type")]
            public string type { get; set; }
            public Angle Angle { get; set; }
            public string EasingType { get; set; }
            public string EasingMode { get; set; }
        }

        public class Angle
        {
            public Value19[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value19
        {
            public float Value { get; set; }
        }

        public class Character
        {
            public string Name { get; set; }
            public string GroupName { get; set; }
            public string Color { get; set; }
            public int Layer { get; set; }
            public Keygesture KeyGesture { get; set; }
            public Voice Voice { get; set; }
            public Volume1 Volume { get; set; }
            public Pan1 Pan { get; set; }
            public float PlaybackRate { get; set; }
            public Voiceparameter1 VoiceParameter { get; set; }
            public float AdditionalTime { get; set; }
            public float VoiceFadeIn { get; set; }
            public float VoiceFadeOut { get; set; }
            public bool EchoIsEnabled { get; set; }
            public float EchoInterval { get; set; }
            public float EchoAttenuation { get; set; }
            public bool CustomVoiceIsEnabled { get; set; }
            public bool CustomVoiceIncludeSubdirectories { get; set; }
            public string CustomVoiceDirectory { get; set; }
            public string CustomVoiceFileName { get; set; }
            public object[] AudioEffects { get; set; }
            public bool IsJimakuVisible { get; set; }
            public bool IsJimakuLocked { get; set; }
            public X1 X { get; set; }
            public Y1 Y { get; set; }
            public Z1 Z { get; set; }
            public Opacity1 Opacity { get; set; }
            public Zoom1 Zoom { get; set; }
            public Rotation1 Rotation { get; set; }
            public float JimakuFadeIn { get; set; }
            public float JimakuFadeOut { get; set; }
            public string Blend { get; set; }
            public bool IsInverted { get; set; }
            public bool IsAlwaysOnTop { get; set; }
            public bool IsZOrderEnabled { get; set; }
            public bool IsClippingWithObjectAbove { get; set; }
            public string Font { get; set; }
            public Fontsize1 FontSize { get; set; }
            public Lineheight21 LineHeight2 { get; set; }
            public Letterspacing21 LetterSpacing2 { get; set; }
            public float DisplayInterval { get; set; }
            public string WordWrap { get; set; }
            public Maxwidth1 MaxWidth { get; set; }
            public string BasePoint { get; set; }
            public string FontColor { get; set; }
            public string Style { get; set; }
            public string StyleColor { get; set; }
            public bool Bold { get; set; }
            public bool Italic { get; set; }
            public bool IsTrimEndSpace { get; set; }
            public bool IsDevidedPerCharacter { get; set; }
            public object[] JimakuVideoEffects { get; set; }
            public string TachieType { get; set; }
            public Tachiecharacterparameter TachieCharacterParameter { get; set; }
            public int MouseSmooth { get; set; }
            public bool IsTachieLocked { get; set; }
            public Tachiex TachieX { get; set; }
            public Tachiey TachieY { get; set; }
            public Tachiez TachieZ { get; set; }
            public Tachieopacity TachieOpacity { get; set; }
            public Tachiezoom TachieZoom { get; set; }
            public Tachierotation TachieRotation { get; set; }
            public float TachieFadeIn { get; set; }
            public float TachieFadeOut { get; set; }
            public string TachieBlend { get; set; }
            public bool TachieIsInverted { get; set; }
            public bool TachieIsAlwaysOnTop { get; set; }
            public bool TachieIsZOrderEnabled { get; set; }
            public bool TachieIsClippingWithObjectAbove { get; set; }
            public Tachiedefaultitemparameter TachieDefaultItemParameter { get; set; }
            public object[] TachieItemVideoEffects { get; set; }
            public Tachiedefaultfaceparameter TachieDefaultFaceParameter { get; set; }
            public object[] TachieDefaultFaceEffects { get; set; }
            public object AdditionalForegroundTemplateName { get; set; }
            public object AdditionalBackgroundTemplateName { get; set; }
            public int VoiceItemLength { get; set; }
            public int TachieItemLength { get; set; }
            public Voiceitemkeyframes VoiceItemKeyFrames { get; set; }
            public Tachieitemkeyframes TachieItemKeyFrames { get; set; }
        }

        public class Keygesture
        {
            public int Key { get; set; }
            public int Modifiers { get; set; }
        }

        public class Voice
        {
            public string API { get; set; }
            public string Arg { get; set; }
        }

        public class Volume1
        {
            public Value20[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value20
        {
            public float Value { get; set; }
        }

        public class Pan1
        {
            public Value21[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value21
        {
            public float Value { get; set; }
        }

        public class Voiceparameter1
        {
            [JsonPropertyName("$type")]
            public string type { get; set; }
            public int Speed { get; set; }
        }

        public class X1
        {
            public Value22[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value22
        {
            public float Value { get; set; }
        }

        public class Y1
        {
            public Value23[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value23
        {
            public float Value { get; set; }
        }

        public class Z1
        {
            public Value24[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value24
        {
            public float Value { get; set; }
        }

        public class Opacity1
        {
            public Value25[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value25
        {
            public float Value { get; set; }
        }

        public class Zoom1
        {
            public Value26[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value26
        {
            public float Value { get; set; }
        }

        public class Rotation1
        {
            public Value27[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value27
        {
            public float Value { get; set; }
        }

        public class Fontsize1
        {
            public Value28[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value28
        {
            public float Value { get; set; }
        }

        public class Lineheight21
        {
            public Value29[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value29
        {
            public float Value { get; set; }
        }

        public class Letterspacing21
        {
            public Value30[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value30
        {
            public float Value { get; set; }
        }

        public class Maxwidth1
        {
            public Value31[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value31
        {
            public float Value { get; set; }
        }

        public class Tachiecharacterparameter
        {
            [JsonPropertyName("$type")]
            public string type { get; set; }
            public string Directory { get; set; }
            public float EyeBlinkStart { get; set; }
            public float EyeBlinkInterval { get; set; }
            public float MouthSensitivity { get; set; }
        }

        public class Tachiex
        {
            public Value32[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value32
        {
            public float Value { get; set; }
        }

        public class Tachiey
        {
            public Value33[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value33
        {
            public float Value { get; set; }
        }

        public class Tachiez
        {
            public Value34[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value34
        {
            public float Value { get; set; }
        }

        public class Tachieopacity
        {
            public Value35[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value35
        {
            public float Value { get; set; }
        }

        public class Tachiezoom
        {
            public Value36[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value36
        {
            public float Value { get; set; }
        }

        public class Tachierotation
        {
            public Value37[] Values { get; set; }
            public float Span { get; set; }
            public string AnimationType { get; set; }
        }

        public class Value37
        {
            public float Value { get; set; }
        }

        public class Tachiedefaultitemparameter
        {
            [JsonPropertyName("$type")]
            public string type { get; set; }
            public bool IsHiddenWhenNoSpeech { get; set; }
            public string Eyebrow { get; set; }
            public string Eye { get; set; }
            public string Mouth { get; set; }
            public string Hair { get; set; }
            public object Complexion { get; set; }
            public string Body { get; set; }
            public object Back1 { get; set; }
            public object Back2 { get; set; }
            public object Back3 { get; set; }
            public object Etc1 { get; set; }
            public object Etc2 { get; set; }
            public object Etc3 { get; set; }
        }

        public class Tachiedefaultfaceparameter
        {
            [JsonPropertyName("$type")]
            public string type { get; set; }
            public string EyeAnimation { get; set; }
            public string MouthAnimation { get; set; }
            public object Eyebrow { get; set; }
            public object Eye { get; set; }
            public object Mouth { get; set; }
            public object Hair { get; set; }
            public object Complexion { get; set; }
            public object Body { get; set; }
            public object Back1 { get; set; }
            public object Back2 { get; set; }
            public object Back3 { get; set; }
            public object Etc1 { get; set; }
            public object Etc2 { get; set; }
            public object Etc3 { get; set; }
        }

        public class Voiceitemkeyframes
        {
            public object[] Frames { get; set; }
            public int Count { get; set; }
        }

        public class Tachieitemkeyframes
        {
            public object[] Frames { get; set; }
            public int Count { get; set; }
        }

    }
}
