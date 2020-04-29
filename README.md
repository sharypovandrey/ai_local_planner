# ai_local_planner
AI Local Planning for ROS

cd ~/catkin_ws/src/mrobot_gazebo/launch
roslaunch mrobot_laser_nav_gazebo.launch

cd ~/catkin_ws/src/mrobot_navigation/launch
roslaunch fake_nav_cloister_demo.launch


1) download https://github.com/ethz-asl/tensorflow_catkin to src
2) download "https://raw.githubusercontent.com/Kitware/CMake/v3.8.0/Modules/ExternalProject.cmake" and put to the tensorflow_catkin folder
3) comment out line in CMakeLists.txt
```
file(DOWNLOAD "https://raw.githubusercontent.com/Kitware/CMake/v3.8.0/Modules/ExternalProject.cmake" ${CMAKE_CURRENT_SOURCE_DIR}/ExternalProject.cmake)
```
4) download https://github.com/tradr-project/tensorflow_ros_cpp to src
5) (opetional) https://github.com/tradr-project/tensorflow_ros_test has an example how to use tensorflow_ros_cpp
6) catkin build (catkin_make does not work)