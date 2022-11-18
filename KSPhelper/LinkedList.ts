class Treenode {
    id?: String;
    children:Treenode[] = [];
    parent?: Treenode;
    value?: Number;

    public constructor(id: String | undefined, children: Treenode[], parent: Treenode | undefined, value: Number | undefined) {
        this.id = id;
        this.children = children;
        this.parent = parent;
        this.value = value;
    }

    //getter methods for id, children, parent, value

    public getId(): String | undefined{
        return this.id;
    }

    public getChildren(): Treenode[] {
        return this.children;
    }

    public getChild(wantedId: String): Treenode[] | undefined {
        let success = false;
        for(let i=0; i<this.children.length; i++){
            if((this.children[i]).getId() === wantedId){
                success = true;
                return [this.children[i]];
            }
        }
        return undefined;
    }

    public getParent(): Treenode | undefined{
        return this.parent;
    }

    public getValue(): Number | undefined{
        return this.value;
    }

    //setter methods for id, children, parent and value

    public setId(id: String): void{
        this.id = id;
    }

    public setChildren(children: Treenode[]): void{
        this.children = children;
    }

    public setParent(parent: Treenode): void{
        this.parent = parent;
    }

    public setValue(value: Number): void{
        this.value = value;
    }

    // adder and remover methods for children

    public addChildren(child: Treenode): void{
        let len: number | undefined;
        len = this.children?.length;
        if(this.children != undefined && len != undefined){
            this.children[len+1] = child;
        } else {
            return;
        }
    }

    public removeChildren(wantedId: String): boolean{
        let success: boolean = false;
        if(this.children===undefined){
            return success;
        }
        else {
            let newChildren: Treenode[] = [];
            let currentChild: Treenode | undefined;
            let wantedTreenode: Treenode = new Treenode(undefined, [], undefined, undefined);
            for(var i in this.children){
                if((this.children[i]).getId() !== wantedId){
                    currentChild = this.children.shift();
                    if(currentChild !== undefined){
                        newChildren.push();
                    }
                }
                else {
                    currentChild = this.children.shift();
                    if(currentChild !== undefined){
                        wantedTreenode = currentChild;
                        success = true;
                    }
                }
            }
            this.children = newChildren;
        }
        return success;
    }

    // 


    
}
