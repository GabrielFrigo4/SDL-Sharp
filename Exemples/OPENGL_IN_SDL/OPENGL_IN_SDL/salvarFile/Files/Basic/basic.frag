#version 460 core

out vec4 outputColor;

in vec2 texCoord;

uniform sampler2D sprite;

void main()
{
    outputColor = texture(sprite, texCoord);
}