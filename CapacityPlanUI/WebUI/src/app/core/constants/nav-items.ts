import { INavItem } from "../interface/i-nav-item";

export const NavItems: INavItem[] = [
    {
        displayName: 'Dashboard',
        iconName: 'fa-tachometer-alt',
        route: '/home/dashboard',
    },
    {
        displayName: 'TEST',
        iconName: 'fa-tachometer-alt',
        route: '/home/dashboard',
        children: [
            {
                displayName: 'TEST1',
                iconName: 'fa-tachometer-alt',
                route: '/home/dashboard',
            },
            {
                displayName: 'TEST2',
                iconName: 'fa-tachometer-alt',
                route: '/home/dashboard',
            }
            ]
    }
    
];