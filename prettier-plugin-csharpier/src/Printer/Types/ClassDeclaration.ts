import { Doc } from "prettier";
import { printComments } from "../Comments";
import { printValue, HasModifiers, HasValue, SyntaxTreeNode, HasIdentifier, printIdentifier } from "../SyntaxTreeNode";
import { PrintMethod } from "../PrintMethod";
import { concat, group, hardline, indent, join, softline, line, doubleHardline } from "../Builders";
import { printModifiers } from "../PrintModifiers";
import { BaseListNode } from './BaseList';

export interface ClassDeclarationNode extends SyntaxTreeNode<"ClassDeclaration">, HasModifiers, HasIdentifier {
    keyword: HasValue;
    members: SyntaxTreeNode[];
    baseList: BaseListNode;
}

export const print: PrintMethod<ClassDeclarationNode> = (path, options, print) => {
    const node = path.getValue();
    const parts: Doc[] = [];
    printComments(parts, node);
    parts.push(printModifiers(node));
    parts.push(printValue(node.keyword));
    parts.push(" ", printIdentifier(node));

    if (node.baseList) {
        parts.push(path.call(print, "baseList"));
    }
    
    const hasMembers = node.members.length > 0;
    if (hasMembers) {
        parts.push(concat([hardline, "{"]));
        parts.push(indent(concat([hardline, join(hardline, path.map(print, "members"))])));
        parts.push(hardline);
        parts.push("}");
    } else {
        parts.push(" ", "{", " ", "}");
    }

    return concat(parts);
};