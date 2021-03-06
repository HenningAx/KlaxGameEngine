﻿cbuffer matrixBuffer : register(b0)
{
    float4x4 modelViewProjection;
}

struct VS_INPUT
{
    float2 pos : POSITION;
    float4 col : COLOR0;
    float2 uv : TEXCOORD0;
};

struct PS_INPUT
{
    float4 pos : SV_POSITION;
    float4 col : COLOR0;
    float2 uv : TEXCOORD0;
};

PS_INPUT Vertex(VS_INPUT input)
{
    PS_INPUT output;
    output.pos = mul(modelViewProjection, float4(input.pos.xy, 0.0f, 1.0f));
    output.col = input.col;
    output.uv = input.uv;
    return output;
}