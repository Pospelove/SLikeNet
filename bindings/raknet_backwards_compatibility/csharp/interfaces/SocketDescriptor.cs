/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class SocketDescriptor : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SocketDescriptor(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SocketDescriptor obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SocketDescriptor() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_SocketDescriptor(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SocketDescriptor() : this(RakNetPINVOKE.new_SocketDescriptor__SWIG_0(), true) {
  }

  public SocketDescriptor(ushort _port, string _hostAddress) : this(RakNetPINVOKE.new_SocketDescriptor__SWIG_1(_port, _hostAddress), true) {
  }

  public ushort port {
    set {
      RakNetPINVOKE.SocketDescriptor_port_set(swigCPtr, value);
    } 
    get {
      ushort ret = RakNetPINVOKE.SocketDescriptor_port_get(swigCPtr);
      return ret;
    } 
  }

  public string hostAddress {
    set {
      RakNetPINVOKE.SocketDescriptor_hostAddress_set(swigCPtr, value);
    } 
    get {
      string ret = RakNetPINVOKE.SocketDescriptor_hostAddress_get(swigCPtr);
      return ret;
    } 
  }

  public short socketFamily {
    set {
      RakNetPINVOKE.SocketDescriptor_socketFamily_set(swigCPtr, value);
    } 
    get {
      short ret = RakNetPINVOKE.SocketDescriptor_socketFamily_get(swigCPtr);
      return ret;
    } 
  }

  public ushort remotePortRakNetWasStartedOn_PS3_PSP2 {
    set {
      RakNetPINVOKE.SocketDescriptor_remotePortRakNetWasStartedOn_PS3_PSP2_set(swigCPtr, value);
    } 
    get {
      ushort ret = RakNetPINVOKE.SocketDescriptor_remotePortRakNetWasStartedOn_PS3_PSP2_get(swigCPtr);
      return ret;
    } 
  }

  public int chromeInstance {
    set {
      RakNetPINVOKE.SocketDescriptor_chromeInstance_set(swigCPtr, value);
    } 
    get {
      int ret = RakNetPINVOKE.SocketDescriptor_chromeInstance_get(swigCPtr);
      return ret;
    } 
  }

  public bool blockingSocket {
    set {
      RakNetPINVOKE.SocketDescriptor_blockingSocket_set(swigCPtr, value);
    } 
    get {
      bool ret = RakNetPINVOKE.SocketDescriptor_blockingSocket_get(swigCPtr);
      return ret;
    } 
  }

  public uint extraSocketOptions {
    set {
      RakNetPINVOKE.SocketDescriptor_extraSocketOptions_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.SocketDescriptor_extraSocketOptions_get(swigCPtr);
      return ret;
    } 
  }

}

}
