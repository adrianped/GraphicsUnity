Shader "Unlit/Hologram"
{
	Properties
	{
		//Main Properties
		_MainTex ("Texture", 2D) = "white" {}
		//Sets tint color
		_TintColor("Tint Color", Color) = (1,1,1,1)
		//Locks Transparency to .5
		_Transparency("Transparency", Range(0.0,0.5)) = 0.25
	}
	SubShader
	{
		//Queues transparency
		Tags { "Queue"="AlphaTest" "RenderType"="Transparent"}
		LOD 100

		ZWRITE Off
		Blend SrcAlpha OneMinusSrcAlpha

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			float4 _TintColor;
			float _Transparency;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				// sample the texture
				fixed4 col = tex2D(_MainTex, i.uv);			
				col.a = _Transparency;				
				return col;
			}
			ENDCG
		}
	}
}
