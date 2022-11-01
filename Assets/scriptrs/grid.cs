using UnityEngine;

public class grid : MonoBehaviour
{
    public int width = 6;
    public int height = 6;
    public int depth = 6;

    public cell cellprefab_inner;
    public cell cellprefab_outer;
    cell[] cells;

    void Awake()
    {
        cells = new cell[height * width * depth];

        for (int z = 0, i = 0; z < height; z++)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < depth; y++)
                {
                    if (y < depth - 1)
                    {
                        CreateCell(x, z, y, i++, cellprefab_inner);
                    } else if (y == depth - 1)
                    {
                        CreateCell(x, z, y, i++, cellprefab_outer);
                    }
                }
            }
        }
    }
    void CreateCell(int x, int z, int y, int i, cell prefab)
    {

        Vector3 position;
        //Смещение сетки на размер целла. Править тут! 
        position.x = x * 2f;
        position.y = y * 2f;
        position.z = z * 2f;
        cell cell = cells[i] = Instantiate<cell>(prefab);
        cell.transform.SetParent(transform, false);
        cell.transform.localPosition = position;
    }
}
