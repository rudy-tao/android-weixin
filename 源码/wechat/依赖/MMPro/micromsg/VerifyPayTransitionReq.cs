﻿namespace micromsg
{
    using ProtoBuf;
    using System;
    using System.ComponentModel;

    [Serializable, ProtoContract(Name="VerifyPayTransitionReq")]
    public class VerifyPayTransitionReq : IExtensible
    {
        private micromsg.BaseRequest _BaseRequest;
        private string _ExtInfo = "";
        private string _OutTradeNo = "";
        private uint _Type;
        private IExtension extensionObject;

        IExtension IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }

        [ProtoMember(1, IsRequired=true, Name="BaseRequest", DataFormat=DataFormat.Default)]
        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return this._BaseRequest;
            }
            set
            {
                this._BaseRequest = value;
            }
        }

        [ProtoMember(4, IsRequired=false, Name="ExtInfo", DataFormat=DataFormat.Default), DefaultValue("")]
        public string ExtInfo
        {
            get
            {
                return this._ExtInfo;
            }
            set
            {
                this._ExtInfo = value;
            }
        }

        [ProtoMember(3, IsRequired=false, Name="OutTradeNo", DataFormat=DataFormat.Default), DefaultValue("")]
        public string OutTradeNo
        {
            get
            {
                return this._OutTradeNo;
            }
            set
            {
                this._OutTradeNo = value;
            }
        }

        [ProtoMember(2, IsRequired=true, Name="Type", DataFormat=DataFormat.TwosComplement)]
        public uint Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this._Type = value;
            }
        }
    }
}

