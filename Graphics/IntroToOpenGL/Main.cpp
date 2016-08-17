//#define GLM_FORCE_PURE

#include "SolarSystem.h"
#include<iostream>
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
	mat4 projection = glm::perspective(glm::pi<float>() * 0.35f,
		16 / 9.f, 0.1f, 1000.f);


	glClearColor(0.25f, 0.25f, 0.25f, 1);
	glEnable(GL_DEPTH_TEST); // enables the depth buffer


	mat4 sun = mat4(1);
	sun[3] = vec4(0, 0, 0, 0);

	mat4 earth = mat4(1);
	earth[3] = vec4(-8, 0, 0, 0);

	mat4 moon = mat4(1);
	moon[3] = vec4(-5, 0, 0, 0);


	while (glfwWindowShouldClose(window) == false &&
		glfwGetKey(window, GLFW_KEY_ESCAPE) != GLFW_PRESS) {
		// our game logic and update code goes here!
		// so does our render code!

		float time = (float)glfwGetTime();

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

		float ex = earth[3].x;
		float ey = earth[3].y;
		float ez = earth[3].z;

		float mx = moon[3].x;
		float my = moon[3].y;
		float mz = moon[3].z;

		moon = earth * glm::translate(vec3(-3.f, 0.f, 3.f));
		ez = ez + .20 * cos(time);
		ex = ex + .20 * sin(time);

		mz = mz + .20 * cos(time);
		mx = mx + .20 * sin(time);

		earth[3].x = ex;
		earth[3].z = ez;

		moon[3].x = mx;
		moon[3].z = mz;

		vec4 orange(255, 128, 0, 1);
		vec4 blue(0, 0, 255, 1);
		vec4 red(255, 0, 0, 1);

		Gizmos::addLine(vec3(moon[3][0], moon[3][1], moon[3][2]), vec3(earth[3][0], earth[3][1], earth[3][2]), red);
		Gizmos::addLine(vec3(earth[3][0], earth[3][1], earth[3][2]), vec3(sun[3][0], sun[3][1], sun[3][2]), blue);

	    Gizmos::addSphere(vec3(sun[3][0], sun[3][1], sun[3][2]), 1, 10, 10, orange, nullptr, 0.0f, 360.0f, -90.0f, 90.0f);
		Gizmos::addSphere(vec3(earth[3][0], earth[3][1], earth[3][2]), 0.75f, 10, 10, blue, nullptr, 0.0f, 360.0f, -90.0f, 90.0f);
		Gizmos::addSphere(vec3(moon[3][0],moon[3][1],moon[3][2]), 0.5f, 10, 10, red, nullptr, 0.0f, 360.0f, -90.0f, 90.0f);

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