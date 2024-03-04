class TileSet {
    List<int> _ids = new List<int>();
    List<string> _groups = new List<string>();

    public TileSet(List<int> ids) {
        this._ids = ids;
    }

    public TileSet(List<string> groups) {
        this._groups = groups;
    }

    public TileSet(List<int> ids, List<string> groups) {
        this._ids = ids;
        this._groups = groups;
    }
}