//#define GLM_FORCE_PURE
#include <gizmos\Gizmos.h>
#include "src\gl_core_4_4.h"
#include <GLFW\glfw3.h>
#include <glm\glm.hpp>
#include <glm\ext.hpp>
#include<glm\gtc\matrix_transform.hpp>

using glm::vec3;
using glm::vec4;
using glm::mat4;

int main()
{
	if (glfwInit() == false)
		return -1;

	GLFWwindow* window = glfwCreateWindow(1080, 720, "Window", nullptr, nullptr);

	if (window == nullptr)
	{
		glfwTerminate();
		return -2;
	}
		

	
	glfwMakeContextCurrent(window);

	if (ogl_LoadFunctions() == ogl_LOAD_FAILED) {
		glfwDestroyWindow(window);
		glfwTerminate();
		return -3;
	}


	Gizmos::create();
	mat4 view = glm::lookAt(vec3(10, 10, 10), vec3(0), vec3(0, 1, 0));
	mat4 projection = glm::perspective(glm::pi<float>() * 0.25f,
		16 / 9.f, 0.1f, 1000.f);

	glClearColor(0.25f, 0.25f, 0.25f, 1);
	glEnable(GL_DEPTH_TEST); // enables the depth buffer


	while (glfwWindowShouldClose(window) == false &&
		glfwGetKey(window, GLFW_KEY_ESCAPE) != GLFW_PRESS) {
		// our game logic and update code goes here!
		// so does our render code!


		//GL_COLOR_BUFFER_BIT informs OpenGL to wipe the back - buffer colours clean.
		//GL_DEPTH_BUFFER_BIT informs it to clear the distance to the closest pixels.If we didn’t do this then
	    //OpenGL may think the image of the last frame is still there and our new visuals may not display.
		glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);


		Gizmos::clear();
		Gizmos::addTransform(glm::mat4(1));

		vec4 white(1);
		vec4 black(0, 0, 0, 1);
		for (int i = 0; i < 21; ++i) {
			Gizmos::addLine(vec3(-10 + i, 0, 10),
				vec3(-10 + i, 0, -10),
				i == 10 ? white : black);
			Gizmos::addLine(vec3(10, 0, -10 + i),
				vec3(-10, 0, -10 + i),
				i == 10 ? white : black);
		}
		
		vec3 Sun(0, 0, 0);
		vec3 Planet(-10, 0, 0);
		vec3 Moon(-8, 0, 0);

		vec4 orange(255, 128, 0,1);
		vec4 blue(0, 0, 255, 1);
		vec4 red(255, 0, 0, 1);
		

	    Gizmos::addSphere(Sun,1, 10, 10, orange, nullptr, 0.0f, 360.0f, -90.0f, 90.0f);
		Gizmos::addSphere(Planet, 0.75f, 10, 10, blue, nullptr, 0.0f, 360.0f, -90.0f, 90.0f);
		Gizmos::addSphere(Moon, 0.5f, 10, 10, red, nullptr, 0.0f, 360.0f, -90.0f, 90.0f);
		
		Gizmos::draw(projection * view);

		//This updates the monitors display but swapping the rendered back buffer.If we did not call this then we wouldn’t be able to see
	    //anything rendered by us with OpenGL.
		glfwSwapBuffers(window);
		glfwPollEvents();
	}
	
	Gizmos::destroy();
	glfwDestroyWindow(window);
	glfwTerminate();
	return 0;
}