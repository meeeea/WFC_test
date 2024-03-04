class Neighbor {
    TileSet _up = new TileSet();
    TileSet _upRight = new TileSet();
    TileSet _right = new TileSet();
    TileSet _downRight = new TileSet();
    TileSet _down = new TileSet();
    TileSet _downLeft = new TileSet();
    TileSet _left = new TileSet();
    TileSet _upLeft = new TileSet();

    public Neighbor(List<TileSet> neighbors) {
        this._up = neighbors[0];
        this._upRight = neighbors[1];
        this._right = neighbors[2];
        this._downRight = neighbors[3];
        this._down = neighbors[4];
        this._downLeft = neighbors[5];
        this._left = neighbors[6];
        this._upLeft = neighbors[7];
    }
}