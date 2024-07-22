using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace ProceduralModeling
{
    public class Quad : ProceduralModelingBase
    {
        [SerializeField, Range(0.1f, 10f)] protected float size = 1f;

        protected override Mesh Build()
        {
            // 매쉬 인스턴스의 생성
            var mesh = new Mesh();

            // Quad의 위아래와 양 옆 폭이 각각 size의 길이가 되도록 구성한다.
            var hsize = size * 0.5f;

            // Quad의 정점 데이터
            var vertices = new Vector3[]
            {
                new Vector3(-hsize, hsize,0f ), // 0번 정점, quad 왼쪽 위의 위치
                 new Vector3(hsize, hsize, 0f), // 1번 정점, quad 오른쪽 위의 위치
                new Vector3(hsize, -hsize, 0f), // 2번 정점, quad 왼쪽 아래의 위치
                new Vector3(-hsize, -hsize, 0f) // 3번 정점, quad 오른쪽 아래의 위치
            };

            // Quad의 uv좌표 데이터
            var uv = new Vector2[]
            {
                new Vector2(0f,0f), // 0번 정점의 uv좌표
                new Vector2(1f,0f), // 1번 정점의 uv좌표
                new Vector2(1f,1f), // 2번 정점의 uv좌표
                new Vector2(0f,1f) // 3번 정점의 uv좌표
            };

            // Quad의 법선 데이터
            var normals = new Vector3[]
            {
                new Vector3(0f,0f,-1f), // 0번 정점의 법선
                new Vector3(0f,0f,-1f), // 1번 정점의 법선
                new Vector3(0f,0f,-1f), // 2번 정점의 법선
                new Vector3(0f,0f,-1f) // 3번 정점의 법선
            };

            var triangles = new int[]
            {
                0, 1, 2, // 첫 번째 삼각형
                2, 3, 0 // 두 번째 삼각형
            };


            mesh.vertices = vertices;
            mesh.uv = uv;
            mesh.normals = normals;
            mesh.triangles = triangles;

            mesh.RecalculateBounds();

            return mesh;
        }

    }

}