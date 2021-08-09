# TmirrorT - Unity Tools

<img src="https://github.com/seyedmoeinsaadati/TMirrorT/blob/main/media/unityLogo.png" align="right" height="70px">
Mirror game objects along point, axis and plane

If you like this project and/or find it useful, please leave a **Star** on this repository.

## Features

- Mirror game objects along:
  - X, Y, Z axes.
  - XZ, XY, ZY plane.
  - a point with custom rotation axes. (you can set up your custom mirror along point)

## Showcase

<img src="https://github.com/seyedmoeinsaadati/TMirrorT/blob/main/media/main.gif">

<img src="https://github.com/seyedmoeinsaadati/TMirrorT/blob/main/media/axis_mirror.gif">

<img src="https://github.com/seyedmoeinsaadati/TMirrorT/blob/main/media/plane_mirror.gif" >

<img src="https://github.com/seyedmoeinsaadati/TMirrorT/blob/main/media/point_mirror.gif">

## Do you wanna Demo?

1. Download latest TMirrorT package.

2. Open it in unity editor.

3. Open "Demo" Scene and play it.

   * <img src="https://github.com/seyedmoeinsaadati/TMirrorT/blob/main/media/axis_mirror.png" align="right">

     

   * Plane mirror component:

     <img src="https://github.com/seyedmoeinsaadati/TMirrorT/blob/main/media/plane_mirror.png" align="right">

   * Point Mirror component:

     <img src="https://github.com/seyedmoeinsaadati/TMirrorT/blob/main/media/point_mirror.png" align="right">

     * you can limit point mirror axis with 'be axis' field and also change rotation behavior with 'custom rotation quaternion' field)

## How to use TmirrorT ?

1. Create a new Unity project.

2. Import TmirrorT package.

3. Create a simple scene

4. Add a cube game object. (reference object)

5. Add empty game object and change name Mirror

6. Add (axis mirror/plane mirror/point mirror) component to Mirror :

   * Axis Mirror component:

     * Mirror objects along X, Y, Z axes.

     <img src="https://github.com/seyedmoeinsaadati/TMirroT/blob/main/media/axis_mirror.png" align="right">

     

   * Plane mirror component:

     * Mirror objects along XZ, XY, ZY axes.

     <img src="https://github.com/seyedmoeinsaadati/TMirroT/blob/main/media/plane_mirror.png" align="right">

   * Point Mirror component:

     * Mirror objects along a point

     <img src="https://github.com/seyedmoeinsaadati/TMirroT/blob/main/media/point_mirror.png" align="right">

     * you can limit point mirror axis with 'be axis' field and also change rotation behavior with 'custom rotation quaternion' field)

7. Add another cube game object and change name Mirror Object (blue)

8. Add Mirror Transform component to Mirror Object.

9. Select first cube game object (yellow) as target and Mirror (red) as mirror

10. Press play and enjoy

## License

It's free. enjoy it. 

**It is prohibited to sublicense and/or sell copies of this project in stores such as the Unity Asset Store!**

© Seyed Moein Saadati

[![](https://img.shields.io/static/v1?label=Website&message=www.seyedmoeinsaadati.github.io&color=brightgreen)](https://www.seyedmoeinsaadati.github.io)
[![](https://img.shields.io/static/v1?label=G-mail&message=saadatimoin@gmail.com&color=blue)](mailto:saadatimoin@gmail.com)
