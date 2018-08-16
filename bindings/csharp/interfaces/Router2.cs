/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace SLNet {

using System;
using System.Runtime.InteropServices;

public class Router2 : PluginInterface2 {
  private HandleRef swigCPtr;

  internal Router2(IntPtr cPtr, bool cMemoryOwn) : base(SLikeNetPINVOKE.Router2_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Router2 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Router2() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SLikeNetPINVOKE.delete_Router2(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static Router2 GetInstance() {
    IntPtr cPtr = SLikeNetPINVOKE.Router2_GetInstance();
    Router2 ret = (cPtr == IntPtr.Zero) ? null : new Router2(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(Router2 i) {
    SLikeNetPINVOKE.Router2_DestroyInstance(Router2.getCPtr(i));
  }

  public Router2() : this(SLikeNetPINVOKE.new_Router2(), true) {
  }

  public void SetSocketFamily(ushort _socketFamily) {
    SLikeNetPINVOKE.Router2_SetSocketFamily(swigCPtr, _socketFamily);
  }

  public void EstablishRouting(RakNetGUID endpointGuid) {
    SLikeNetPINVOKE.Router2_EstablishRouting(swigCPtr, RakNetGUID.getCPtr(endpointGuid));
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMaximumForwardingRequests(int max) {
    SLikeNetPINVOKE.Router2_SetMaximumForwardingRequests(swigCPtr, max);
  }

  public void SetDebugInterface(Router2DebugInterface _debugInterface) {
    SLikeNetPINVOKE.Router2_SetDebugInterface(swigCPtr, Router2DebugInterface.getCPtr(_debugInterface));
  }

  public Router2DebugInterface GetDebugInterface() {
    IntPtr cPtr = SLikeNetPINVOKE.Router2_GetDebugInterface(swigCPtr);
    Router2DebugInterface ret = (cPtr == IntPtr.Zero) ? null : new Router2DebugInterface(cPtr, false);
    return ret;
  }

  public uint GetConnectionRequestIndex(RakNetGUID endpointGuid) {
    uint ret = SLikeNetPINVOKE.Router2_GetConnectionRequestIndex(swigCPtr, RakNetGUID.getCPtr(endpointGuid));
    if (SLikeNetPINVOKE.SWIGPendingException.Pending) throw SLikeNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum Router2RequestStates {
    R2RS_REQUEST_STATE_QUERY_FORWARDING,
    REQUEST_STATE_REQUEST_FORWARDING
  }

}

}
