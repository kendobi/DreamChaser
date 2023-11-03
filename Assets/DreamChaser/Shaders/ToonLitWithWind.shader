Shader "Custom/StandardWithWindScrollingVertex"
{
    Properties
    {
        _Color ("Main Color", Color) = (1, 1, 1, 1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _WindSpeed ("Wind Speed", Range(0, 10)) = 1
        _WindAmplitude ("Wind Amplitude", Range(0, 1)) = 0.1
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" }
        LOD 200

        Pass
        {
            Blend SrcAlpha OneMinusSrcAlpha
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 texcoord : TEXCOORD0;
            };

            struct v2f
            {
                float2 texcoord : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            float4 _Color;
            sampler2D _MainTex;
            float4 _MainTex_ST;
            float _WindSpeed;
            float _WindAmplitude;

            v2f vert(appdata_t v)
            {
                v2f o;
                // Offset the vertex position along the UVs to create the scrolling effect
                o.vertex = UnityObjectToClipPos(v.vertex + float4(0, sin(_Time.y * _WindSpeed) * _WindAmplitude * v.texcoord.y, 0, 0));
                o.texcoord = TRANSFORM_TEX(v.texcoord, _MainTex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.texcoord);
                col.a *= _Color.a; // Preserve alpha
                return col;
            }
            ENDCG
        }
    }
}
