#version 330 core
out vec4 FragColor;

//uniform vec4 ourColor;
in vec3 ourColor;
void main()
{
    //FragColor=ourColor;
    FragColor = vec4(ourColor,1.0);
}