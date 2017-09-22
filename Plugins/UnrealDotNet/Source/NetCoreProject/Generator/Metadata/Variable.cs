﻿using System;
using System.Collections.Generic;

namespace Generator.Metadata
{
    public abstract class Variable : Primitive, IEquatable<Variable>
    {
        public bool IsConst { get; set; }
        public bool IsPointer { get; set; }
        public bool IsReference { get; set; }

        public string Type { get; protected set; }
        public string Default { get; set; }

        protected Variable()
        {
            UMeta = new Dictionary<string, string>();
        }

        public virtual string GetTypeCS()
        {
            return Type;
        }

        public virtual bool IsReadOnly()
        {
            return false;
        }

        public virtual string GetTypeCSForExtend(bool ForReturn = false)
        {
            return Type;
        }

        public virtual string GetTypeCPP(bool ForReturn = false)
        {
            return Type;
        }

        public override string ToString()
        {
            var result = "";

            if (IsConst)
                result += "const ";
            if (IsPointer)
                result += "ptr ";
            if (IsReference)
                result += "ref ";

            return result;
        }

        public string GetTypeCPPOgiginal(bool NoName = false)
        {
            var result = "";

            if (IsConst)
                result += "const ";

            result += Type;

            if (IsPointer)
                result += "*";
            if (IsReference)
                result += "&";

            if (!string.IsNullOrEmpty(Name) && !NoName)
                result += " " + Name;

            return result;
        }

        public bool Equals(Variable other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return IsConst == other.IsConst && IsPointer == other.IsPointer && IsReference == other.IsReference && string.Equals(Type, other.Type);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Variable)obj);
        }

        public override int GetHashCode()
        {
            var hashCode = -1979447941;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }

    public class PrimitiveVariable : Variable
    {
        public static readonly string[] PrimitiveTypes =
        {
            "void",
            "int",
            "uint8",
            "int16",
            "int32",
            "int64",
            "bool",
            "FString",
            "FText",
            "FName",
            "string",
            "float",
            "double",
            "char",
            "byte",
            "IntPtr"
        };

        public PrimitiveVariable(string Type)
        {
            this.Type = Type;
        }

        public override string GetTypeCS()
        {
            switch (Type)
            {
                case "uint8":
                    return "byte";

                case "int32":
                    return "int";

                case "uint32":
                    return "uint";

                case "int64":
                    return "long";

                case "uint64":
                    return "ulong";

                case "FString":
                case "FText":
                case "FName":
                    return "string";

                case "INT_PTR":
                    return "IntPtr";

                default:
                    return Type;
            }
        }

        public override string GetTypeCSForExtend(bool ForReturn = false)
        {
            return GetTypeCS();
        }

        public override string GetTypeCPP(bool ForReturn = false)
        {
            switch (Type)
            {
                case "FString":
                case "FText":
                case "FName":
                    return "char*";

                default:
                    return Type;
            }
        }

        public override string ToString()
        {
            var b = base.ToString();
            return string.IsNullOrEmpty(Name) ? b + Type : $"{b}{Type} {Name}";
        }
    }

    public class ClassVariable : Variable
    {
        public Class Class { get; }

        public ClassVariable(Class ClassType)
        {
            this.Class = ClassType;
            this.Type = ClassType.Name;
        }

        public override string GetTypeCPP(bool ForReturn = false)
        {
            if (Class.IsStructure)
                return "INT_PTR";
            
            if (ForReturn)
                return "ObjectPointerDescription";

            var name = Class.Name;

            if (IsReference)
                return name + "&";

            if (IsPointer)
                return name + "*";

            return name;
        }

        public override bool IsReadOnly()
        {
            return Class.IsReadOnly;
        }

        public override string GetTypeCS()
        {
            return Class.Name;
        }

        public override string GetTypeCSForExtend(bool ForReturn = false)
        {
            if (!Class.IsStructure && ForReturn)
                return "ObjectPointerDescription";

            return "IntPtr";
        }

        public override string ToString()
        {
            var b = base.ToString();
            return string.IsNullOrEmpty(Name) ? b + Class : $"{b}{Class} {Name}";
        }
    }

    public class EnumVariable : Variable
    {
        public Enum Enum { get; }

        public EnumVariable(Enum Enum)
        {
            this.Enum = Enum;
            this.Type = Enum.Name;
        }

        public override string GetTypeCPP(bool ForReturn = false)
        {
            return Type;
        }

        public override string GetTypeCS()
        {
            return Type;
        }

        public override string GetTypeCSForExtend(bool ForReturn = false)
        {
            return "byte";
        }

        public override string ToString()
        {
            var b = base.ToString();
            return string.IsNullOrEmpty(Name) ? b + Enum : $"{b}{Enum} {Name}";
        }
    }

    public class DelegateVariable : Variable
    {
        public Delegate Delegate { get; }

        public DelegateVariable(Delegate DelegateType)
        {
            this.Delegate = DelegateType;
        }

        public override string GetTypeCPP(bool ForReturn = false)
        {
            return Delegate.Name;
        }

        public override bool IsReadOnly()
        {
            return false;
        }

        public override string GetTypeCS()
        {
            return Delegate.Name;
        }

        public override string GetTypeCSForExtend(bool ForReturn = false)
        {
            return Delegate.Name;
        }

        public override string ToString()
        {
            var b = base.ToString();
            return string.IsNullOrEmpty(Name) ? b + Delegate : $"{b}{Delegate} {Name}";
        }
    }
}