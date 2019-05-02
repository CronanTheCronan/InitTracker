import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { CreatureComponent } from './creature/creature.component';
import { CombatComponent } from './combat/combat.component';
import { SetupComponent } from './setup/setup.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent },
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'creatures', component: CreatureComponent },
            { path: 'combat', component: CombatComponent },
            { path: 'setup', component: SetupComponent }
        ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full' }
];
