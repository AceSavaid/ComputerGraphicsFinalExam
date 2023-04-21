Shader "Outline/ToonOutline"
{
    Properties
    {
        _Color("Color", Color) = (1,1,1,1)
        _MainTex("Texture", 2D) = "white" {}
        _RampTex("Toon Ramp Texture", 2D) = "white" {}
        _Contribution("Contribution", Range(0, 1)) = 0.5

        _OutlineColor("Outline Color", Color) = (0,0,0,1)
        _OutlineWidth("Outline Width", Range(0.002, 0.2)) = 0.01
    }
    SubShader
    {

        Tags { "Geometry" = "Transparent" } 
        //LOD 200

        ZWrite off //turns off z buffer so object is behind everything else
        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Lambert vertex:vert

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        float _OutlineWidth;
        fixed4 _Color;
        fixed4 _OutlineColor;

        void vert(inout appdata_full v)
        {
            v.vertex.xyz += v.normal * _OutlineWidth;  //extrudes vertices in the direction of the normals by the amount
        }


        void surf(Input IN, inout SurfaceOutput o)
        {
            // Albedo comes from a texture tinted by colour
            o.Emission = _OutlineColor.rgb;
        }
        ENDCG
        ZWrite on


        //Toon shading
        CGPROGRAM

        #pragma surface surf ToonRamp

        float4 _Color;
        sampler2D _MainTex;
        sampler2D _RampTex;
        float _Contribution;

        float4 LightingToonRamp(SurfaceOutput s, fixed3 lightDir, fixed atten) {

            float diff = dot(s.Normal, lightDir);
            float h = diff * 0.5 + 0.5;
            float2 rh = h;
            float3 ramp = tex2D(_RampTex, rh).rgb;

            float4 c;
            c.rgb = s.Albedo * _LightColor0.rgb * (ramp * _Contribution);
            c.a = s.Alpha;
            return c;
        }

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf(Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
            o.Albedo = c.rgb;
        }
        ENDCG
    }
}
