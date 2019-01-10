#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#define DEBUG 1
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <MapKit/MapKit.h>
#import <CoreLocation/CoreLocation.h>
#import <QuartzCore/QuartzCore.h>
#import <CoreGraphics/CoreGraphics.h>

@class UIApplicationDelegate;
@class UIKit_UIControlEventProxy;
@class Foundation_NSDispatcher;
@class __MonoMac_NSSynchronizationContextDispatcher;
@class __Xamarin_NSTimerActionDispatcher;
@class Foundation_NSAsyncDispatcher;
@class __MonoMac_NSAsyncSynchronizationContextDispatcher;
@class AppDelegate;
@class AcceuilController;
@class registerController;
@class tabController;
@class tab2;
@class newsTab;
@class mapsTab;
@class profileTab;
@class ViewController;
@class MapKit_MKMapView__MKMapViewDelegate;
@class __UIGestureRecognizerToken;
@class __UIGestureRecognizerParameterlessToken;
@class __NSObject_Disposer;
@class OpenTK_Platform_iPhoneOS_CADisplayLinkTimeSource;
@class OpenTK_Platform_iPhoneOS_iPhoneOSGameView;

@interface UIApplicationDelegate : NSObject<UIApplicationDelegate> {
}
	-(id) init;
@end

@interface AppDelegate : NSObject<UIApplicationDelegate, UIApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1;
	-(void) applicationWillResignActive:(UIApplication *)p0;
	-(void) applicationDidEnterBackground:(UIApplication *)p0;
	-(void) applicationWillEnterForeground:(UIApplication *)p0;
	-(void) applicationDidBecomeActive:(UIApplication *)p0;
	-(void) applicationWillTerminate:(UIApplication *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface AcceuilController : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(void) UIButton22653_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface registerController : UIViewController {
}
	@property (nonatomic, assign) UISwitch * accepted;
	@property (nonatomic, assign) UITextField * ageTxt;
	@property (nonatomic, assign) UITextField * emailTxt;
	@property (nonatomic, assign) UITextField * firstTxt;
	@property (nonatomic, assign) UITextField * lastTxt;
	@property (nonatomic, assign) UITextField * pwdText;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UISwitch *) accepted;
	-(void) setAccepted:(UISwitch *)p0;
	-(UITextField *) ageTxt;
	-(void) setAgeTxt:(UITextField *)p0;
	-(UITextField *) emailTxt;
	-(void) setEmailTxt:(UITextField *)p0;
	-(UITextField *) firstTxt;
	-(void) setFirstTxt:(UITextField *)p0;
	-(UITextField *) lastTxt;
	-(void) setLastTxt:(UITextField *)p0;
	-(UITextField *) pwdText;
	-(void) setPwdText:(UITextField *)p0;
	-(void) viewDidLoad;
	-(void) UIButton14918_TouchUpInside:(UIButton *)p0;
	-(void) UIButton16004_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface tabController : UITabBarController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface tab2 : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface newsTab : UIViewController {
}
	@property (nonatomic, assign) UIButton * disconnect;
	@property (nonatomic, assign) UILabel * hiLabel;
	@property (nonatomic, assign) UIScrollView * scrollNews;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) disconnect;
	-(void) setDisconnect:(UIButton *)p0;
	-(UILabel *) hiLabel;
	-(void) setHiLabel:(UILabel *)p0;
	-(UIScrollView *) scrollNews;
	-(void) setScrollNews:(UIScrollView *)p0;
	-(void) viewDidLoad;
	-(void) Disconnect_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface mapsTab : UIViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface profileTab : UIViewController {
}
	@property (nonatomic, assign) UIScrollView * scrollView;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIScrollView *) scrollView;
	-(void) setScrollView:(UIScrollView *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * getButton;
	@property (nonatomic, assign) UITextField * textUser;
	@property (nonatomic, assign) UITextField * txtPwd;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) getButton;
	-(void) setGetButton:(UIButton *)p0;
	-(UITextField *) textUser;
	-(void) setTextUser:(UITextField *)p0;
	-(UITextField *) txtPwd;
	-(void) setTxtPwd:(UITextField *)p0;
	-(void) viewDidLoad;
	-(void) viewDidAppear:(BOOL)p0;
	-(void) UIButton13100_TouchUpInside:(UIButton *)p0;
	-(void) UIButton24532_TouchUpInside:(UIButton *)p0;
	-(void) UIButton589_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface __UIGestureRecognizerToken : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface __UIGestureRecognizerParameterlessToken : __UIGestureRecognizerToken {
}
	-(void) target;
@end

@interface OpenTK_Platform_iPhoneOS_iPhoneOSGameView : UIView {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	+(Class) layerClass;
	-(void) layoutSubviews;
	-(void) willMoveToWindow:(UIWindow *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) initWithFrame:(CGRect)p0;
@end


