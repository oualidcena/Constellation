namespace Constellation.Unity {
    public static class UnityNodeFactory {
        public static Node<INode> GetNode (string nodeName) {
            switch (nodeName) {
                case DeltaTime.NAME:
                    INode nodeDeltaTime = new DeltaTime () as INode;
                    return new Node<INode> (nodeDeltaTime);
                case KeyDown.NAME:
                    INode nodeKeyDown = new KeyDown () as INode;
                    return new Node<INode> (nodeKeyDown);
                case Transform.NAME:
                    INode nodeTransform = new Transform () as INode;
                    return new Node<INode> (nodeTransform);
                case Vec3.NAME:
                    INode nodeVec3 = new Vec3 () as INode;
                    return new Node<INode> (nodeVec3);
                case Key.NAME:
                    INode nodeKey = new Key () as INode;
                    return new Node<INode> (nodeKey);
                case FindByName.NAME:
                    INode nodeFindByName = new FindByName () as INode;
                    return new Node<INode> (nodeFindByName);
                case ObjectAttribute.NAME:
                    INode nodeObjectAttribute = new ObjectAttribute () as INode;
                    return new Node<INode> (nodeObjectAttribute);
                case SplitVec3.NAME:
                    INode nodeSplitVec3 = new SplitVec3 () as INode;
                    return new Node<INode> (nodeSplitVec3);
                case Update.NAME:
                    INode nodeUpdate = new Update () as INode;
                    return new Node<INode> (nodeUpdate);
                case LateUpdate.NAME:
                    INode nodeLateUpdate = new LateUpdate () as INode;
                    return new Node<INode> (nodeLateUpdate);
                case MouseButtonDown.NAME:
                    INode nodeMouseButtonDown = new MouseButtonDown() as INode;
                    return new Node<INode> (nodeMouseButtonDown);
                case PlayerPreferences.NAME:
                    INode nodePlayerPref = new PlayerPreferences() as INode;
                    return new Node<INode> (nodePlayerPref);
                case SetActive.NAME:
                    INode nodeSetActive = new SetActive() as INode;
                    return new Node<INode> (nodeSetActive);
                case LoadScene.NAME:
                    INode nodeLoadScene = new LoadScene() as INode;
                    return new Node<INode> (nodeLoadScene);
                default:
                    return null;
            }
        }
    }
}