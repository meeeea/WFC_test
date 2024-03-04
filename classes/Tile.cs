class Tile {
    
    int _id = null;
    string _name = "";

    List<string> _groups = new List<string>();

    Neighbor _neighbor = new Neighbor();
    
    public Tile(int id, string name, List<string> groups = null) {
        this._id = id;
        this._name = name;
        
        if (groups != null) {
            this._groups = new List<string>(groups);
        }
    }
}