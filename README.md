# LCA
Masivian LCA test

Author: Diego Alejandro Gaitán - dalejandro.gaitan@gmail.com

This repository was created as solution to test for Masivian company, this solution was developed:

<b>Backend:</b> REST API - .Net Framework 4.7.2 - ASP.NET

<b>Deploy and test:</b> To run this project, open the solution 'LCA.WebApi.sln', run on the preferred web server. Tests were run on IIS Express, using Swagger IO or using the API manager of preference, you must go to the address: http://localhost:8081/swagger/ui/index, to use the respective end-points video is attached demonstrative: https://www.loom.com/share/802c967ee525485280222da1f8595a9b.

* <b>/api/BinaryTreeController/AddBinaryTree:</b> Method POST to create a binary tree according to a numeric data collection.
* <b>GET /api/BinaryTreeController/GetLowestCommonAncestor/{nodeValueFirst}/{nodeValueSecond}:</b> Method GET to get the lowest common ancestor of a binary tree.
