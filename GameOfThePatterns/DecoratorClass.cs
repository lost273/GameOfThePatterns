using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThePatterns {
    abstract class Component {
        public abstract void Operation();
    }
    class ConcreteComponent : Component {
        public override void Operation() {
            
        }
    }
    abstract class DecoratorClass : Component{
        protected Component component;
        public void SetComponent(Component component) {
            this.component = component;
        }
        public override void Operation() {
            if (component != null) component.Operation();
        }
    }
    //additional functionality
    class ConcreteDecorator : DecoratorClass {
        public override void Operation() {
            base.Operation();
        }
    }
    class LetsDecoratorGame {
        public static void Start() {

        }
    }
}
