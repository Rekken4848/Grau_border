Shader "Custom/OutlineShader"
{
    Properties
    {
        _OutlineColor ("Outline Color", Color) = (1,1,0,1) // Amarillo
        _OutlineThickness ("Outline Thickness", Range(0.001, 0.03)) = 0.01
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                float4 color : COLOR;
            };

            float _OutlineThickness;
            float4 _OutlineColor;

            v2f vert(appdata v)
            {
                v2f o;
                float3 norm = mul((float3x3)unity_ObjectToWorld, v.normal);
                float3 offset = norm * _OutlineThickness;
                o.pos = UnityObjectToClipPos(v.vertex + float4(offset, 0.0));
                o.color = _OutlineColor;
                return o;
            }

            half4 frag(v2f i) : SV_Target
            {
                return i.color;
            }
            ENDCG
        }
    }
}
