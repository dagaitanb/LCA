# LCA
Masivian LCA test

Author: Diego Alejandro Gaitán - dalejandro.gaitan@gmail.com

This repository was created as a solution for Masivian admission test, development:

<b>Backend:</b> REST API - .Net Framework 4.7.2 - ASP.NET

<b>Deploy and test:</b> To run this project, open the solution 'LCA.WebApi.sln', run on the preferred web server. Tests were run on IIS Express, using Swagger UI or using the API manager of preference, you must go to the address: http://localhost:8081/swagger/ui/index, to use the respective end-points video is attached demonstrative: https://www.loom.com/share/558c0be153754342bad1fb232c2a9ccc

* <b>/api/BinaryTreeController/AddBinaryTree:</b> Method POST to create a binary tree according to a numeric data collection.
* <b>/api/BinaryTreeController/GetLowestCommonAncestor/{first}/{second}:</b> Method GET to get the lowest common ancestor of a binary tree.
