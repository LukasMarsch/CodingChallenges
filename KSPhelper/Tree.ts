class Tree {
    start: Treenode;

    // @ts-ignore
    constructor(start: Treenode):void {
        this.start = start;
    }

    getElementById(start: Treenode, id: String): Treenode | undefined {
        let current: Treenode;
        current = this.start;
        let children: Treenode[];
        while(current.getId() != id){

        }

        return undefined;
    }

}