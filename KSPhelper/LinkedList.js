var Treenode = /** @class */ (function () {
    function Treenode(id, children, parent, value) {
        this.children = [];
        this.id = id;
        this.children = children;
        this.parent = parent;
        this.value = value;
    }
    //getter methods for id, children, parent, value
    Treenode.prototype.getId = function () {
        return this.id;
    };
    Treenode.prototype.getChildren = function () {
        return this.children;
    };
    Treenode.prototype.getChild = function (wantedId) {
        var success = false;
        for (var i = 0; i < this.children.length; i++) {
            if ((this.children[i]).getId() === wantedId) {
                success = true;
                return [this.children[i]];
            }
        }
        return undefined;
    };
    Treenode.prototype.getParent = function () {
        return this.parent;
    };
    Treenode.prototype.getValue = function () {
        return this.value;
    };
    //setter methods for id, children, parent and value
    Treenode.prototype.setId = function (id) {
        this.id = id;
    };
    Treenode.prototype.setChildren = function (children) {
        this.children = children;
    };
    Treenode.prototype.setParent = function (parent) {
        this.parent = parent;
    };
    Treenode.prototype.setValue = function (value) {
        this.value = value;
    };
    // adder and remover methods for children
    Treenode.prototype.addChildren = function (child) {
        var _a;
        var len;
        len = (_a = this.children) === null || _a === void 0 ? void 0 : _a.length;
        if (this.children != undefined && len != undefined) {
            this.children[len + 1] = child;
        }
        else {
            return;
        }
    };
    Treenode.prototype.removeChildren = function (wantedId) {
        var success = false;
        if (this.children === undefined) {
            return success;
        }
        else {
            var newChildren = [];
            var currentChild = void 0;
            var wantedTreenode = new Treenode(undefined, [], undefined, undefined);
            for (var i in this.children) {
                if ((this.children[i]).getId() !== wantedId) {
                    currentChild = this.children.shift();
                    if (currentChild !== undefined) {
                        newChildren.push();
                    }
                }
                else {
                    currentChild = this.children.shift();
                    if (currentChild !== undefined) {
                        wantedTreenode = currentChild;
                        success = true;
                    }
                }
            }
            this.children = newChildren;
        }
        return success;
    };
    return Treenode;
}());
