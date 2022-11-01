var Treenode = /** @class */ (function () {
    function Treenode() {
        this.children = Array(Treenode);
    }
    Treenode.prototype.node = function (children, parent, newName) {
        this.parent = parent;
        this.children = children;
        this.id = newName;
    };
    return Treenode;
}());
function getName() {
    return this.id;
}
function getChild(wantedId) {
    this.children.forEach(function (c) {
        if (wantedId === c.getName()) {
            return c;
        }
    });
    return null;
}
