#include <stdio.h>
#include <stdlib.h>
#include <vector>

#define TILE_SIZE		64
#define TILESET_SIZE	3*256

#define FILE_ORIGINAL	"C:\\Fernando\\Temp\\tileset.gfx"
#define FILE_CONVERTED	"C:\\Fernando\\Temp\\tileset_converted.txt"

struct Tile
{
	int Pixels[TILE_SIZE] = { 0 };
};

std::vector<Tile> Graphics;

int main(int argc, char* args[])
{
	FILE* fp = NULL;
	fopen_s(&fp, FILE_ORIGINAL, "rb");
	printf("Loading " FILE_ORIGINAL "\n");

	while (!feof(fp))
	{
		Tile tile;

		for (int i = 0; i < TILE_SIZE; i++)
		{
			char pixch = fgetc(fp);

			tile.Pixels[i] = pixch == '1' ? 1 : 0;
		}

		Graphics.push_back(tile);
	}

	printf("Loaded OK " FILE_ORIGINAL "\n");
	fclose(fp);
	
	fopen_s(&fp, FILE_CONVERTED, "wb");
	printf("Created " FILE_CONVERTED "\n");

	for (int t = 0; t < Graphics.size(); t++)
	{
		Tile& tile = Graphics[t];
		
		fprintf(fp, "\tAddTile(\"");

		for (int i = 0; i < TILE_SIZE; i++)
		{
			fprintf(fp, "%i", tile.Pixels[i]);

			if (i < TILE_SIZE - 1)
				fputc(',', fp);
		}

		fprintf(fp, "\");\n");
	}

	printf("Conversion finished OK\n");
	fflush(fp);
	fclose(fp);

	system("Pause");

	return 0;
}
