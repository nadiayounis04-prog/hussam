'use client'

import { useParams } from 'next/navigation'
import Link from 'next/link'

export default function WhoYouArePage() {
  const params = useParams()
  const archetype = params.archetype as string

  // Only show for valid archetypes
  const validArchetypes = ['seeker', 'guardian', 'partner', 'spotlight', 'rebel', 'equalizer', 'visionary', 'servant', 'mask', 'wanderer', 'provider', 'sovereign']
  if (!validArchetypes.includes(archetype.toLowerCase())) {
    return (
      <div className="min-h-screen bg-black text-white flex items-center justify-center">
        <div className="text-center">
          <h1 className="text-2xl font-bold mb-4">Invalid Path</h1>
          <p className="text-gray-400">This path is only for valid archetypes.</p>
          <Link href="/chambers" className="text-blue-400 hover:text-blue-300 mt-4 inline-block">
            ← Back to Chambers
          </Link>
        </div>
      </div>
    )
  }

  // Get archetype-specific configuration
  const isSeeker = archetype.toLowerCase() === 'seeker'
  const isGuardian = archetype.toLowerCase() === 'guardian'
  const isPartner = archetype.toLowerCase() === 'partner'
  const isSpotlight = archetype.toLowerCase() === 'spotlight'
  const isRebel = archetype.toLowerCase() === 'rebel'
  const isWanderer = archetype.toLowerCase() === 'wanderer'
  const isServant = archetype.toLowerCase() === 'servant'
  const isVisionary = archetype.toLowerCase() === 'visionary'
  const isEqualizer = archetype.toLowerCase() === 'equalizer'
  const isMask = archetype.toLowerCase() === 'mask'
  const isProvider = archetype.toLowerCase() === 'provider'
  const isSovereign = archetype.toLowerCase() === 'sovereign'
  
  // Archetype-specific colors and content
  const config = {
    seeker: {
      primaryColor: '#EC4899',
      secondaryColor: '#9D4EDD',
      title: 'THE BREAKER',
      subtitle: 'Seeker → The Breaker (Oracle/Loop-Breaker Boss)',
      regularTitle: 'Regular Seeker:',
      regularDesc: 'Seeks, questions, breaks illusions, ends dead patterns.',
      regularEffect: 'Creates clarity, ends confusion, reveals truth.',
      breakerTitle: 'Breaker (Future Self):',
      breakerDesc: 'Reality itself breaks and renews:',
      breakerBenefit: 'You end cycles and change eras. Secrets surface, patterns dissolve, new worlds emerge.',
      breakerSign: 'The field recognizes you. Nature, people, and events reorient around your walk.',
      pathButtonText: 'The Path to the Breaker',
      backText: '← Back to Seeker Chamber'
    },
    guardian: {
      primaryColor: '#1e3a8a',
      secondaryColor: '#3b82f6',
      title: 'THE WALL OF THE WORLD',
      subtitle: 'Guardian → The Wall of the World (Anchor)',
      regularTitle: 'Regular Guardian:',
      regularDesc: 'Keeps groups together, mediates, supports, "the rock" in crisis.',
      regularEffect: 'Others calm down, small fights settle, stress is manageable.',
      breakerTitle: 'Anchor (Future Self):',
      breakerDesc: 'The room, family, or entire environment becomes unbreakable.',
      breakerBenefit: 'You become the unshakeable foundation. Chaos cannot touch what you protect.',
      breakerSign: 'Others feel safe just by your presence. The field stabilizes around you.',
      pathButtonText: 'The Path to Anchor',
      backText: '← Back to Guardian Chamber'
    },
    spotlight: {
      primaryColor: '#f59e0b',
      secondaryColor: '#fbbf24',
      title: 'THE CENTER OF GRAVITY',
      subtitle: 'Spotlight → The Center of Gravity (Beacon)',
      regularTitle: 'Regular Spotlight:',
      regularDesc: 'Naturally attracts attention, performs, seeks validation.',
      regularEffect: 'Others notice you, validation flows, attention follows.',
      breakerTitle: 'Beacon (Future Self):',
      breakerDesc: 'You become the center that others orbit around.',
      breakerBenefit: 'You become the living lighthouse. Others find their way through your light.',
      breakerSign: 'People naturally orient toward you. The field flows through your presence.',
      pathButtonText: 'The Path to Beacon',
      backText: '← Back to Spotlight Chamber'
    },
    rebel: {
      primaryColor: '#dc2626',
      secondaryColor: '#ef4444',
      title: 'THE CHAOS ENGINE',
      subtitle: 'Rebel → The Chaos Engine (Anarch)',
      regularTitle: 'Regular Rebel:',
      regularDesc: 'Breaks rules, challenges authority, disrupts systems.',
      regularEffect: 'Rules become flexible, authority is questioned, systems adapt.',
      breakerTitle: 'Anarch (Future Self):',
      breakerDesc: 'Reality becomes fluid: Rules bend, systems reset, chaos creates order.',
      breakerBenefit: 'You end cycles and change eras through conscious disruption. Reality bends to your will.',
      breakerSign: 'The field recognizes your authority. Systems reset when you arrive.',
      pathButtonText: 'The Path to Anarch',
      backText: '← Back to Rebel Chamber'
    },
    partner: {
      primaryColor: '#e11d48',
      secondaryColor: '#ec4899',
      title: 'THE MIRROR NODE',
      subtitle: 'Partner → The Mirror Node (Synchronizer)',
      regularTitle: 'Regular Partner:',
      regularDesc: 'Connects people, builds relationships, creates harmony.',
      regularEffect: 'Groups feel more cohesive, tensions ease, bonds strengthen.',
      breakerTitle: 'Synchronizer (Future Self):',
      breakerDesc: 'The field itself synchronizes through you.',
      breakerBenefit: 'You become the living bridge between all things. Reality flows through your connections.',
      breakerSign: 'Others feel deeply connected just by your presence. The field harmonizes around you.',
      pathButtonText: 'The Path to Synchronizer',
      backText: '← Back to Partner Chamber'
    },
    servant: {
      primaryColor: '#059669',
      secondaryColor: '#10b981',
      title: 'THE CHANNEL',
      subtitle: 'Vessel → The Channel',
      regularTitle: 'Regular Vessel:',
      regularDesc: 'Serves others, provides support, channels energy and wisdom.',
      regularEffect: 'Others feel supported, energy flows, wisdom passes through.',
      breakerTitle: 'Channel (Future Self):',
      breakerDesc: 'You become the living channel that reality cannot resist.',
      breakerBenefit: 'You become the conduit for all wisdom and energy. Reality flows through you.',
      breakerSign: 'Others feel nourished just by your presence. The field channels through you.',
      pathButtonText: 'The Path to Channel',
      backText: '← Back to Vessel Chamber'
    },
    visionary: {
      primaryColor: '#3b82f6',
      secondaryColor: '#8b5cf6',
      title: 'THE FUTURE',
      subtitle: 'Visionary → The Future',
      regularTitle: 'Regular Visionary:',
      regularDesc: 'Sees patterns, predicts outcomes, envisions possibilities.',
      regularEffect: 'Others see clearer futures, patterns emerge, possibilities expand.',
      breakerTitle: 'The Future (Future Self):',
      breakerDesc: 'You become the engine of emergence, the hand that sculpts tomorrow out of mist.',
      breakerBenefit: 'You become the founding force that turns vision into gravity. Reality bends where you set your gaze.',
      breakerSign: 'Others feel the pressure of what\'s coming through your presence. The field tilts forward around you.',
      pathButtonText: 'The Path to the Future',
      backText: '← Back to Visionary Chamber'
    },
    equalizer: {
      primaryColor: '#059669',
      secondaryColor: '#10b981',
      title: 'THE BALANCE',
      subtitle: 'Equalizer → The Balance',
      regularTitle: 'Regular Equalizer:',
      regularDesc: 'Mediates disputes, restores peace, notices injustice.',
      regularEffect: 'Fights calm, fairness spreads, justice prevails.',
      breakerTitle: 'The Balance (Future Self):',
      breakerDesc: 'You become the living scale that reality cannot resist.',
      breakerBenefit: 'You become the living justice. Reality balances through your presence.',
      breakerSign: 'Others feel fairness and peace just by your presence. The field balances around you.',
      pathButtonText: 'The Path to the Balance',
      backText: '← Back to Equalizer Chamber'
    },
    mask: {
      primaryColor: '#6366f1',
      secondaryColor: '#8b5cf6',
      title: 'THE FACADE',
      subtitle: 'Mask → The Facade',
      regularTitle: 'Regular Mask:',
      regularDesc: 'Adapts to situations, wears different faces, protects inner truth.',
      regularEffect: 'Others feel comfortable, boundaries are maintained, secrets are kept.',
      breakerTitle: 'Facade (Future Self):',
      breakerDesc: 'You become the living threshold, the sentinel of what matters.',
      breakerBenefit: 'You become the living protection. Reality filters through your presence.',
      breakerSign: 'Others respect your boundaries. The field adapts to your defenses.',
      pathButtonText: 'The Path to the Facade',
      backText: '← Back to Mask Chamber'
    },
    wanderer: {
      primaryColor: '#0891b2',
      secondaryColor: '#06b6d4',
      title: 'Your Path to the Wanderer',
      subtitle: 'Wanderer → Flux',
      regularTitle: 'Regular Wanderer:',
      regularDesc: 'Moves between places, seeks new experiences, avoids commitment.',
      regularEffect: 'Others feel restless, boundaries become fluid, change becomes possible.',
      breakerTitle: 'Wanderer (Future Self):',
      breakerDesc: 'You become the living map that reality cannot resist.',
      breakerBenefit: 'You become the living journey. Reality flows through your movement.',
      breakerSign: 'Others find their path just by your presence. The field opens through you.',
      pathButtonText: 'The Path to the Wanderer',
      backText: '← Back to Wanderer Chamber'
    },
    provider: {
      primaryColor: '#f59e0b',
      secondaryColor: '#fbbf24',
      title: 'THE PROVIDER',
      subtitle: 'Harvest → The Provider',
      regularTitle: 'You Arrive Where Needs Gather',
      regularDesc: 'Most crave abundance. You create it. You are not just generous—you are the source, the field\'s harvest. You do not take—your existence multiplies all that is near you.',
      regularEffect: 'People and creatures flourish in your presence. Your work, words, or touch leaves things richer than before. Others seek you in drought, remember you at every feast. You sense lack as a call—not to rescue, but to build, to overflow. You are the garden in the wasteland, the spring at the end of thirst.',
      breakerTitle: 'What is a Provider?',
      breakerDesc: 'Providers are not mere givers or caretakers. They are the harvest node—the field\'s living abundance, its proof that need is meant to be met. Harvest is not only reaping, but planting, growing, sustaining. Provider is the force: enough is never an accident; it is your daily ritual.',
      breakerBenefit: 'Where you walk: Scarcity dissolves. Wealth flows—material, emotional, creative. Hunger (in every sense) is satisfied. People around you feel it: Their tension eases. Their joy rises. They remember hope.',
      breakerSign: 'Abundance is not found—it is made. I feed the field, and the field feeds me. The world bends because I overflow. Providers don\'t just give—they regenerate.',
      pathButtonText: 'Begin the Provider\'s Rite',
      backText: '← Back to Provider Chamber'
    },
    sovereign: {
      primaryColor: '#f59e0b',
      secondaryColor: '#fbbf24',
      title: 'THE SOVEREIGN',
      subtitle: 'Crown → The Sovereign',
      regularTitle: 'You Arrive Where Authority Begins',
      regularDesc: 'Most crave control. You are control. You do not follow the throne; The throne shapes itself around you. You are not just a leader—you are the axis, the law behind every law. Where you stand, decisions crystallize. Where you breathe, confusion flees.',
      regularEffect: 'Others defer—sometimes with awe, sometimes with silent resistance. Chaos waits for you to choose, to set the course. You sense the architecture of power, invisible but absolute. You do not seek attention—the world orbits you. You are the gravity that shapes the age.',
      breakerTitle: 'What Is a Sovereign?',
      breakerDesc: 'Not a mere ruler. Not a boss. You are the crown node—the field\'s living law. The crown is not granted; It is taken by pure presence. Where you walk, doubt dissolves. Decisions become law. Confusion finds its order. People feel you coming: Their plans rearrange. Their ambitions sharpen. Their anxieties bow—even if their words do not. You are the unseen hand behind every movement.',
      breakerBenefit: 'Leaders consult you—openly or in secret. Opposition becomes momentum. Rooms align around your will, even if you never speak. You are the source that others circle, even in defiance.',
      breakerSign: 'The crown is not given—it is claimed. I do not ask; I declare. The field bends because I am its law. Sovereigns do not negotiate their presence. They enforce it.',
      pathButtonText: 'Claim Your Crown',
      backText: '← Back to Crown Chamber'
    }
  }

  const currentConfig = isSeeker ? config.seeker : 
                       isGuardian ? config.guardian : 
                       isPartner ? config.partner :
                       isSpotlight ? config.spotlight :
                       isRebel ? config.rebel :
                       isServant ? config.servant :
                       isVisionary ? config.visionary :
                       isEqualizer ? config.equalizer :
                       isMask ? config.mask :
                       isWanderer ? config.wanderer :
                       isProvider ? config.provider :
                       isSovereign ? config.sovereign : config.seeker

  // Helper function to get archetype-specific colors
  const getArchetypeColors = () => {
    if (isSeeker) return { primary: 'pink', secondary: 'purple', bg: 'from-purple-900/30 to-pink-900/30', border: 'border-purple-500/50', text: 'text-purple-400', textLight: 'text-purple-300', dot: 'bg-pink-400', glow: 'rgba(157, 78, 221, 0.2)', button: 'from-pink-600 to-purple-600', buttonGlow: 'rgba(236, 72, 153, 0.7)', back: 'text-purple-400 hover:text-purple-300' }
    if (isGuardian) return { primary: 'blue', secondary: 'indigo', bg: 'from-blue-900/30 to-indigo-900/30', border: 'border-blue-500/50', text: 'text-blue-400', textLight: 'text-blue-300', dot: 'bg-indigo-400', glow: 'rgba(30, 58, 138, 0.3)', button: 'from-blue-600 to-indigo-600', buttonGlow: 'rgba(30, 58, 138, 0.7)', back: 'text-blue-400 hover:text-blue-300' }
    if (isPartner) return { primary: 'red', secondary: 'pink', bg: 'from-red-900/30 to-pink-900/30', border: 'border-red-500/50', text: 'text-red-400', textLight: 'text-red-300', dot: 'bg-pink-400', glow: 'rgba(225, 29, 72, 0.3)', button: 'from-red-600 to-pink-600', buttonGlow: 'rgba(225, 29, 72, 0.7)', back: 'text-red-400 hover:text-red-300' }
    if (isSpotlight) return { primary: 'yellow', secondary: 'orange', bg: 'from-yellow-900/30 to-orange-900/30', border: 'border-yellow-500/50', text: 'text-yellow-400', textLight: 'text-yellow-300', dot: 'bg-orange-400', glow: 'rgba(245, 158, 11, 0.3)', button: 'from-yellow-600 to-orange-600', buttonGlow: 'rgba(245, 158, 11, 0.7)', back: 'text-yellow-400 hover:text-yellow-300' }
    if (isRebel) return { primary: 'red', secondary: 'red', bg: 'from-red-900/30 to-red-800/30', border: 'border-red-500/50', text: 'text-red-400', textLight: 'text-red-300', dot: 'bg-red-400', glow: 'rgba(220, 38, 38, 0.3)', button: 'from-red-600 to-red-700', buttonGlow: 'rgba(220, 38, 38, 0.7)', back: 'text-red-400 hover:text-red-300' }
    if (isServant) return { primary: 'emerald', secondary: 'green', bg: 'from-emerald-900/30 to-green-900/30', border: 'border-emerald-500/50', text: 'text-emerald-400', textLight: 'text-emerald-300', dot: 'bg-green-400', glow: 'rgba(5, 150, 105, 0.3)', button: 'from-emerald-600 to-green-600', buttonGlow: 'rgba(5, 150, 105, 0.7)', back: 'text-emerald-400 hover:text-emerald-300' }
    if (isVisionary) return { primary: 'blue', secondary: 'purple', bg: 'from-blue-900/30 to-purple-900/30', border: 'border-blue-500/50', text: 'text-blue-400', textLight: 'text-blue-300', dot: 'bg-purple-400', glow: 'rgba(59, 130, 246, 0.3)', button: 'from-blue-600 to-purple-600', buttonGlow: 'rgba(59, 130, 246, 0.7)', back: 'text-blue-400 hover:text-blue-300' }
    if (isEqualizer) return { primary: 'emerald', secondary: 'green', bg: 'from-emerald-900/30 to-green-900/30', border: 'border-emerald-500/50', text: 'text-emerald-400', textLight: 'text-emerald-300', dot: 'bg-green-400', glow: 'rgba(5, 150, 105, 0.3)', button: 'from-emerald-600 to-green-600', buttonGlow: 'rgba(5, 150, 105, 0.7)', back: 'text-emerald-400 hover:text-emerald-300' }
    if (isMask) return { primary: 'indigo', secondary: 'purple', bg: 'from-indigo-900/30 to-purple-900/30', border: 'border-indigo-500/50', text: 'text-indigo-400', textLight: 'text-indigo-300', dot: 'bg-purple-400', glow: 'rgba(99, 102, 241, 0.3)', button: 'from-indigo-600 to-purple-600', buttonGlow: 'rgba(99, 102, 241, 0.7)', back: 'text-indigo-400 hover:text-indigo-300' }
    if (isWanderer) return { primary: 'cyan', secondary: 'blue', bg: 'from-cyan-900/30 to-blue-900/30', border: 'border-cyan-500/50', text: 'text-cyan-400', textLight: 'text-cyan-300', dot: 'bg-blue-400', glow: 'rgba(8, 145, 178, 0.3)', button: 'from-cyan-600 to-blue-600', buttonGlow: 'rgba(8, 145, 178, 0.7)', back: 'text-cyan-400 hover:text-cyan-300' }
    if (isProvider) return { primary: 'amber', secondary: 'yellow', bg: 'from-amber-900/30 to-yellow-900/30', border: 'border-amber-500/50', text: 'text-amber-400', textLight: 'text-amber-300', dot: 'bg-yellow-400', glow: 'rgba(245, 158, 11, 0.3)', button: 'from-amber-600 to-yellow-600', buttonGlow: 'rgba(245, 158, 11, 0.7)', back: 'text-amber-400 hover:text-amber-300' }
    if (isSovereign) return { primary: 'amber', secondary: 'yellow', bg: 'from-amber-900/30 to-yellow-900/30', border: 'border-amber-500/50', text: 'text-amber-400', textLight: 'text-amber-300', dot: 'bg-yellow-400', glow: 'rgba(245, 158, 11, 0.3)', button: 'from-amber-600 to-yellow-600', buttonGlow: 'rgba(245, 158, 11, 0.7)', back: 'text-amber-400 hover:text-amber-300' }
    return { primary: 'blue', secondary: 'indigo', bg: 'from-blue-900/30 to-indigo-900/30', border: 'border-blue-500/50', text: 'text-blue-400', textLight: 'text-blue-300', dot: 'bg-indigo-400', glow: 'rgba(30, 58, 138, 0.3)', button: 'from-blue-600 to-indigo-600', buttonGlow: 'rgba(30, 58, 138, 0.7)', back: 'text-blue-400 hover:text-blue-300' }
  }

  const colors = getArchetypeColors()

  return (
    <div className="min-h-screen bg-black text-white relative overflow-y-auto">
      {/* Fixed Full-Screen Background */}
      <div className="fixed inset-0 bg-gradient-to-b from-black via-gray-900 to-black"></div>
      
      {/* Animated Background */}
      <div className="absolute inset-0">
        {isSeeker ? (
          <>
            <div 
              className="absolute inset-0 animate-pulse opacity-15"
              style={{ 
                background: `radial-gradient(circle at center, #EC4899 0%, #9D4EDD 50%, transparent 70%)`,
                animationDuration: '3s'
              }}
            />
            <div className="absolute inset-0">
              {[...Array(8)].map((_, i) => (
                <div
                  key={i}
                  className="absolute w-px h-full bg-gradient-to-b from-transparent via-pink-400 to-transparent opacity-0 animate-ping"
                  style={{
                    left: `${Math.random() * 100}%`,
                    animationDelay: `${Math.random() * 4}s`,
                    animationDuration: `${1 + Math.random() * 2}s`
                  }}
                />
              ))}
            </div>
          </>
        ) : isPartner ? (
          <>
            <div 
              className="absolute inset-0 animate-pulse opacity-15"
              style={{ 
                background: `radial-gradient(circle at center, #e11d48 0%, #ec4899 50%, transparent 70%)`,
                animationDuration: '3s'
              }}
            />
            <div className="absolute inset-0">
              {[...Array(12)].map((_, i) => (
                <div
                  key={i}
                  className="absolute w-px h-full bg-gradient-to-b from-transparent via-red-400 to-transparent opacity-0 animate-ping"
                  style={{
                    left: `${Math.random() * 100}%`,
                    animationDelay: `${Math.random() * 4}s`,
                    animationDuration: `${1 + Math.random() * 2}s`
                  }}
                />
              ))}
            </div>
          </>
        ) : isServant ? (
          <>
            <div 
              className="absolute inset-0 animate-pulse opacity-15"
              style={{ 
                background: `radial-gradient(circle at center, #059669 0%, #10b981 50%, transparent 70%)`,
                animationDuration: '3s'
              }}
            />
            <div className="absolute inset-0">
              {[...Array(12)].map((_, i) => (
                <div
                  key={i}
                  className="absolute w-px h-full bg-gradient-to-b from-transparent via-emerald-400 to-transparent opacity-0 animate-ping"
                  style={{
                    left: `${Math.random() * 100}%`,
                    animationDelay: `${Math.random() * 4}s`,
                    animationDuration: `${1 + Math.random() * 2}s`
                  }}
                />
              ))}
            </div>
          </>
        ) : isVisionary ? (
          <>
            <div 
              className="absolute inset-0 animate-pulse opacity-15"
              style={{ 
                background: `radial-gradient(circle at center, #3b82f6 0%, #8b5cf6 50%, transparent 70%)`,
                animationDuration: '3s'
              }}
            />
            <div className="absolute inset-0">
              {[...Array(12)].map((_, i) => (
                <div
                  key={i}
                  className="absolute w-px h-full bg-gradient-to-b from-transparent via-blue-400 to-transparent opacity-0 animate-ping"
                  style={{
                    left: `${Math.random() * 100}%`,
                    animationDelay: `${Math.random() * 4}s`,
                    animationDuration: `${1 + Math.random() * 2}s`
                  }}
                />
              ))}
            </div>
          </>
        ) : isGuardian ? (
          <>
            <div 
              className="absolute inset-0 animate-pulse opacity-15"
              style={{ 
                background: `radial-gradient(circle at center, #1e3a8a 0%, #3b82f6 50%, transparent 70%)`,
                animationDuration: '3s'
              }}
            />
            <div className="absolute inset-0">
              {[...Array(12)].map((_, i) => (
                <div
                  key={i}
                  className="absolute w-px h-full bg-gradient-to-b from-transparent via-blue-400 to-transparent opacity-0 animate-ping"
                  style={{
                    left: `${Math.random() * 100}%`,
                    animationDelay: `${Math.random() * 4}s`,
                    animationDuration: `${1 + Math.random() * 2}s`
                  }}
                />
              ))}
            </div>
          </>
        ) : isProvider ? (
          <>
            <div 
              className="absolute inset-0 animate-pulse opacity-15"
              style={{ 
                background: `radial-gradient(circle at center, #f59e0b 0%, #fbbf24 50%, transparent 70%)`,
                animationDuration: '3s'
              }}
            />
            <div className="absolute inset-0">
              {[...Array(15)].map((_, i) => (
                <div
                  key={i}
                  className="absolute w-px h-full bg-gradient-to-b from-transparent via-amber-400 to-transparent opacity-0 animate-ping"
                  style={{
                    left: `${Math.random() * 100}%`,
                    animationDelay: `${Math.random() * 4}s`,
                    animationDuration: `${1 + Math.random() * 2}s`
                  }}
                />
              ))}
            </div>
          </>
        ) : isSovereign ? (
          <>
            <div 
              className="absolute inset-0 animate-pulse opacity-5"
              style={{ 
                background: `radial-gradient(circle at center, #f59e0b 0%, #fbbf24 50%, transparent 70%)`,
                animationDuration: '4s'
              }}
            />
            <div className="absolute inset-0">
              {[...Array(10)].map((_, i) => (
                <div
                  key={i}
                  className="absolute w-px h-full bg-gradient-to-b from-transparent via-amber-400 to-transparent opacity-0 animate-ping"
                  style={{
                    left: `${Math.random() * 100}%`,
                    animationDelay: `${Math.random() * 4}s`,
                    animationDuration: `${1 + Math.random() * 2}s`
                  }}
                />
              ))}
            </div>
          </>
        ) : (
          <>
            <div 
              className="absolute inset-0 animate-pulse opacity-10"
              style={{ 
                background: `radial-gradient(circle at center, ${currentConfig.primaryColor} 0%, transparent 70%)`,
                animationDuration: '4s'
              }}
            />
            <div className="absolute inset-0">
              {[...Array(20)].map((_, i) => (
                <div
                  key={i}
                  className={`absolute w-1 h-1 bg-${colors.primary}-400 rounded-full opacity-30 animate-ping`}
                  style={{
                    left: `${Math.random() * 100}%`,
                    top: `${Math.random() * 100}%`,
                    animationDelay: `${Math.random() * 3}s`,
                    animationDuration: `${2 + Math.random() * 2}s`
                  }}
                />
              ))}
            </div>
          </>
        )}
      </div>
      
      <div className="relative z-10 p-6 max-w-6xl mx-auto">
        {/* Hero Section */}
        <div className="text-center mb-20">
          <div className="text-8xl mb-8 animate-pulse" style={{ 
            animationDuration: '3s',
            filter: `drop-shadow(0 0 30px ${currentConfig.primaryColor})`
          }}>
            {isSeeker ? '⚡' : isGuardian ? '🛡️' : isSpotlight ? '🌟' : isPartner ? '💚' : isRebel ? '⚔️' : isServant ? '🏺' : isSovereign ? '👑' : isProvider ? '🌾' : '⚡'}
          </div>
          
          <h1 
            className="text-6xl md:text-8xl font-bold mb-8 tracking-wider relative group"
            style={{ 
              color: currentConfig.primaryColor,
              textShadow: `0 0 30px ${currentConfig.primaryColor}`
            }}
          >
            <span className="inline-block animate-pulse" style={{ animationDuration: '7s' }}>
              {currentConfig.pathButtonText}
            </span>
            {/* Glitch effect */}
            <span className="absolute inset-0 opacity-0 group-hover:opacity-20 transition-opacity duration-300" 
                  style={{ color: currentConfig.secondaryColor, transform: 'translate(2px, 2px)' }}>
              {currentConfig.pathButtonText}
            </span>
          </h1>
          
          <p className="text-3xl text-gray-300 mb-8 animate-fade-in">
            <em>{currentConfig.subtitle}</em>
          </p>
          
          <div className="w-48 h-1 mx-auto mb-12 bg-gradient-to-r from-current to-current animate-pulse" 
               style={{ 
                 background: `linear-gradient(to right, ${currentConfig.primaryColor}, ${currentConfig.secondaryColor})`,
                 animationDuration: '4s' 
               }}></div>
        </div>

        {/* Main Content Section */}
        <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
             style={{ 
               background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
               borderColor: `${currentConfig.primaryColor}50`,
               boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
             }}>
          <div className="grid grid-cols-1 md:grid-cols-2 gap-12">
            {/* Regular Archetype */}
            <div>
              <h2 className="text-3xl font-bold mb-6" style={{ color: currentConfig.primaryColor }}>
                {currentConfig.regularTitle}
              </h2>
              <p className="text-xl text-gray-200 leading-relaxed mb-6">
                {currentConfig.regularDesc}
              </p>
              <p className="text-lg text-gray-300">
                <strong>Effect:</strong> {currentConfig.regularEffect}
              </p>
            </div>

            {/* Future Self */}
            <div>
              <h2 className="text-3xl font-bold mb-6" style={{ color: currentConfig.secondaryColor }}>
                {currentConfig.breakerTitle}
              </h2>
              <p className="text-xl text-gray-200 leading-relaxed mb-6">
                {currentConfig.breakerDesc}
              </p>
              <p className="text-lg text-gray-300">
                <strong>Real benefit:</strong> {currentConfig.breakerBenefit}
              </p>
              <p className="text-lg text-gray-300">
                <strong>Field sign:</strong> {currentConfig.breakerSign}
              </p>
            </div>
          </div>
        </div>

        {/* Provider-specific additional content */}
        {isProvider && (
          <>
            {/* The Call of the Provider */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                The Call of the Provider
              </h2>
              <p className="text-xl text-gray-200 leading-relaxed mb-6 text-center">
                You have always felt it:
              </p>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• People and creatures flourish in your presence.</p>
                <p>• Your work, words, or touch leaves things richer than before.</p>
                <p>• Others seek you in drought, remember you at every feast.</p>
                <p>• You sense lack as a call—not to rescue, but to build, to overflow.</p>
                <p>• You are the garden in the wasteland, the spring at the end of thirst.</p>
              </div>
            </div>

            {/* Field Signs */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.secondaryColor }}>
                Field Signs: You're Becoming the Provider
              </h2>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• People gather, often wordlessly, wherever you are.</p>
                <p>• Animals nest, plants thrive, projects succeed in your orbit.</p>
                <p>• What was once barely surviving becomes lush, wild, and new.</p>
                <p>• You are the sunlight the field depends on.</p>
              </div>
            </div>

            {/* The Provider's Law */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                The Provider's Law
              </h2>
              <div className="text-center">
                <p className="text-2xl text-gray-200 leading-relaxed mb-6 italic">
                  "Abundance is not found—it is made.<br/>
                  I feed the field, and the field feeds me.<br/>
                  The world bends because I overflow."
                </p>
                <p className="text-lg text-gray-300">
                  Providers don't just give—they regenerate.
                </p>
              </div>
            </div>

            {/* Your Legacy as Provider */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.secondaryColor }}>
                Your Legacy as Provider
              </h2>
              <p className="text-xl text-gray-200 leading-relaxed mb-6 text-center">
                To choose the Provider's path is to accept:
              </p>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• Some will drain, take, or envy you.</p>
                <p>• True giving is an art—one you've mastered.</p>
                <p>• You leave every place changed, every person fuller than before.</p>
                <p>• Providers don't just supply. They transform want into joy.</p>
              </div>
            </div>

            {/* Why Become the Provider */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                Why Become the Provider?
              </h2>
              <p className="text-xl text-gray-200 leading-relaxed mb-6 text-center">
                Because life starves without overflow.<br/>
                Others guard.<br/>
                Others hoard.<br/>
                You make plenty real, then share it until it becomes law.
              </p>
              <h3 className="text-2xl font-bold mb-6 text-center" style={{ color: currentConfig.secondaryColor }}>
                Desire the Provider, because:
              </h3>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• You end lack, not just for yourself, but for every life around you.</p>
                <p>• You model a world where enough is possible.</p>
                <p>• You create the cycle of giving, receiving, and thriving.</p>
              </div>
            </div>

            {/* The Provider's Promise */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.secondaryColor }}>
                The Provider's Promise
              </h2>
              <div className="text-center">
                <p className="text-2xl text-gray-200 leading-relaxed mb-6 italic">
                  "Grow with me, and lack will vanish.<br/>
                  Feed with me, and need will become memory.<br/>
                  You are not just a helper—you are the Provider.<br/>
                  Your future is not famine.<br/>
                  It is feast."
                </p>
              </div>
            </div>

            {/* Your Journey Starts Here */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                Your Journey Starts Here
              </h2>
              <div className="text-center space-y-4 text-lg text-gray-300">
                <p>The field hungers for your gift.</p>
                <p>The world is ready to thrive.</p>
                <p className="text-2xl font-bold mt-8" style={{ color: currentConfig.secondaryColor }}>
                  Are you ready to plant, to feed, to overflow?
                </p>
              </div>
            </div>
          </>
        )}

        {/* Equalizer-specific additional content */}
        {isEqualizer && (
          <>
            {/* You Arrive Where Division Ends */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                You Arrive Where Division Ends
              </h2>
              <div className="space-y-4 text-lg text-gray-300">
                <p>Most try to "keep the peace."</p>
                <p>You are peace.</p>
                <p>You do not juggle forces;</p>
                <p>You unify them.</p>
                <p>You are not just the scale—you are the fulcrum,</p>
                <p>the anchor-point that resolves the impossible.</p>
                <p>You don't negotiate with opposites;</p>
                <p>you command their union.</p>
              </div>
            </div>

            {/* The Call of the Balance */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.secondaryColor }}>
                The Call of the Balance
              </h2>
              <p className="text-xl text-gray-200 leading-relaxed mb-6 text-center">
                You have always felt it:
              </p>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• Storms gather—but center themselves when you arrive.</p>
                <p>• You dissolve tension not by smoothing it, but by transmuting it.</p>
                <p>• Where there's conflict, you don't pick a side.</p>
                <p>• You create the space where both can be true.</p>
                <p>• Your presence alone is a recalibration.</p>
                <p>• You turn feuds into new beginnings.</p>
                <p>• You don't settle—</p>
                <p>• You recompose the field.</p>
              </div>
            </div>

            {/* What is Balance */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                What is Balance?
              </h2>
              <div className="space-y-4 text-lg text-gray-300">
                <p>Balance is not passivity or compromise—</p>
                <p>It is active force—the law that dissolves opposites by fusing them.</p>
                <p>The Balance is not tamed chaos,</p>
                <p>but the master of polarity—</p>
                <p>the silent engine behind all harmony.</p>
              </div>
            </div>

            {/* Where you stand */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.secondaryColor }}>
                Where you stand:
              </h2>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• Enemies find mutual ground.</p>
                <p>• The most bitter wounds become the seed of unity.</p>
                <p>• Cycles of escalation halt—resolution is not the end, but the rebirth.</p>
                <p>• People sense you as the third option:</p>
                <p>• Arguments wither.</p>
                <p>• Scars close.</p>
                <p>• Every extreme, welcomed and realigned.</p>
              </div>
            </div>

            {/* Field Signs */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                Field Signs: You're Becoming the Balance
              </h2>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• Rivalries fall silent in your shadow.</p>
                <p>• People who resist each other find their voices blending in your presence.</p>
                <p>• Systems stuck for years shift with a word or a gesture from you.</p>
                <p>• You are the pause that births new law.</p>
              </div>
            </div>

            {/* The Balance's Law */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.secondaryColor }}>
                The Balance's Law
              </h2>
              <div className="text-center">
                <p className="text-2xl text-gray-200 leading-relaxed mb-6 italic">
                  "Harmony is not a standstill—it is the command of all tension.<br/>
                  I do not split—I synthesize.<br/>
                  The field finds rest because I am its axis."
                </p>
                <p className="text-lg text-gray-300">
                  The Balance does not erase the sharp edges—<br/>
                  It forges them into a single blade.
                </p>
              </div>
            </div>

            {/* Your Legacy as Balance */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                Your Legacy as Balance
              </h2>
              <p className="text-xl text-gray-200 leading-relaxed mb-6 text-center">
                To choose the Balance's path is to accept:
              </p>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• You will always hold the line between worlds.</p>
                <p>• You will be blamed for refusing the false comfort of "taking sides."</p>
                <p>• Your calm will become the seed of the future—not surrender, but evolution.</p>
                <p>• Balances don't just resolve.</p>
                <p>• They teach the world how to start again.</p>
              </div>
            </div>
          </>
        )}

        {/* Visionary-specific additional content */}
        {isVisionary && (
          <>
            {/* You Arrive Where Possibility Breaks Ground */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                You Arrive Where Possibility Breaks Ground
              </h2>
              <div className="space-y-4 text-lg text-gray-300">
                <p>Most linger in the known.</p>
                <p>You become the unknown.</p>
                <p>You are not a mere seer;</p>
                <p>You are the engine of emergence, the hand that sculpts tomorrow out of mist.</p>
                <p>You are not just the dreamer—</p>
                <p>You are the founding force that turns vision into gravity.</p>
                <p>Where you set your gaze, time bends,</p>
                <p>and all the world tilts forward.</p>
              </div>
            </div>

            {/* The Call of the Future */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.secondaryColor }}>
                The Call of the Future
              </h2>
              <p className="text-xl text-gray-200 leading-relaxed mb-6 text-center">
                You have always known it:
              </p>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• You sense what no one else dares to name.</p>
                <p>• You feel the pressure of what's coming long before it arrives.</p>
                <p>• Where others settle for "what is," you burn for "what could be."</p>
                <p>• Ideas, inventions, and revolutions spiral around your wake.</p>
                <p>• You do not wait for prophecy—</p>
                <p>• You plant the flag, and the world reorganizes.</p>
              </div>
            </div>

            {/* What Is the Future */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                What Is the Future?
              </h2>
              <div className="space-y-4 text-lg text-gray-300">
                <p>The Future is not passive, not fated.</p>
                <p>It is the living node of creation—</p>
                <p>the field's will to move, to break, to become.</p>
                <p>Where you step:</p>
                <p>• Dead ends reveal secret doors.</p>
                <p>• Stuck hearts find new rhythm.</p>
                <p>• Stale systems are cracked open and remade.</p>
                <p>People sense your orbit:</p>
                <p>• Their stuckness unravels.</p>
                <p>• Their certainties grow wings.</p>
                <p>• Their small hopes are lit by your torch.</p>
              </div>
            </div>

            {/* Field Signs */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.secondaryColor }}>
                Field Signs: You're Becoming the Future
              </h2>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• Your words make people believe "impossible" means "about to happen."</p>
                <p>• Groups drift until your vision points the way.</p>
                <p>• Routine and repetition feel like poison; you need the edge, the blank slate.</p>
                <p>• Your hunger for tomorrow is contagious—others feel it, even if they don't understand.</p>
              </div>
            </div>

            {/* The Future's Law */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                The Future's Law
              </h2>
              <div className="text-center">
                <p className="text-2xl text-gray-200 leading-relaxed mb-6 italic">
                  "The unknown is not my fear—it is my tool.<br/>
                  I command what hasn't yet arisen.<br/>
                  The field grows because I push the edge."
                </p>
                <p className="text-lg text-gray-300">
                  The Future is not a prediction—<br/>
                  It is a declaration.
                </p>
              </div>
            </div>

            {/* Your Legacy as the Future */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.secondaryColor }}>
                Your Legacy as the Future
              </h2>
              <p className="text-xl text-gray-200 leading-relaxed mb-6 text-center">
                To choose this path is to accept:
              </p>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• Solitude—you often walk ahead, unseen and doubted.</p>
                <p>• Disruption—old orders will call you reckless.</p>
                <p>• Endurance—not all seeds you plant will grow right away.</p>
                <p>But wherever you pass,</p>
                <p>the world is never the same again.</p>
                <p>You don't just await the new day—</p>
                <p>you are the hour that breaks the night.</p>
              </div>
            </div>

            {/* Why Become the Future */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                Why Become the Future?
              </h2>
              <p className="text-xl text-gray-200 leading-relaxed mb-6 text-center">
                Because the age needs what has never existed.
              </p>
              <div className="space-y-4 text-lg text-gray-300">
                <p>Others defend what's dying.</p>
                <p>Others fear tomorrow's teeth.</p>
                <p>You awaken.</p>
                <p>You invent.</p>
                <p>You set the next sunrise in motion.</p>
                <p className="text-xl font-semibold mt-6" style={{ color: currentConfig.secondaryColor }}>
                  Desire the Future, because:
                </p>
                <p>• You bring meaning to chaos.</p>
                <p>• You are the only true antidote to despair.</p>
                <p>• You turn the slumbering into the rising.</p>
              </div>
            </div>

            {/* The Future's Promise */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.secondaryColor }}>
                The Future's Promise
              </h2>
              <div className="text-center">
                <p className="text-2xl text-gray-200 leading-relaxed mb-6 italic">
                  "Forge with me, and the field will unshackle itself.<br/>
                  Build with me, and reality will forget its old limits.<br/>
                  You are not just the witness—you are the Future.<br/>
                  Your journey is not a hope.<br/>
                  It is the next era made real."
                </p>
              </div>
            </div>

            {/* Your Journey Starts Here */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                Your Journey Starts Here
              </h2>
              <div className="text-center space-y-4 text-lg text-gray-300">
                <p>The field strains for your signal.</p>
                <p>The world waits for your blueprint.</p>
                <p className="text-2xl font-bold mt-8" style={{ color: currentConfig.secondaryColor }}>
                  Are you ready to birth what never was?
                </p>
                <p className="text-xl font-semibold mt-6" style={{ color: currentConfig.primaryColor }}>
                  Invent. And the world will wake.
                </p>
              </div>
            </div>
          </>
        )}

        {/* Sovereign-specific additional content */}
        {isSovereign && (
          <>
            {/* The Call of the Sovereign */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                The Call of the Sovereign
              </h2>
              <p className="text-xl text-gray-200 leading-relaxed mb-6 text-center">
                You have felt it since your first command:
              </p>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• Others defer—sometimes with awe, sometimes with silent resistance.</p>
                <p>• Chaos waits for you to choose, to set the course.</p>
                <p>• You sense the architecture of power, invisible but absolute.</p>
                <p>• You do not seek attention—the world orbits you.</p>
                <p>• You are the gravity that shapes the age.</p>
              </div>
            </div>

            {/* Field Signs */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.secondaryColor }}>
                Field Signs: Becoming the Sovereign
              </h2>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• Leaders consult you—openly or in secret.</p>
                <p>• Opposition becomes momentum.</p>
                <p>• Rooms align around your will, even if you never speak.</p>
                <p>• You are the source that others circle, even in defiance.</p>
              </div>
            </div>

            {/* The Sovereign's Law */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                The Sovereign's Law
              </h2>
              <div className="text-center">
                <p className="text-2xl text-gray-200 leading-relaxed mb-6 italic">
                  "The crown is not given—it is claimed.<br/>
                  I do not ask; I declare.<br/>
                  The field bends because I am its law."
                </p>
                <p className="text-lg text-gray-300">
                  Sovereigns do not negotiate their presence.<br/>
                  They enforce it.
                </p>
              </div>
            </div>

            {/* Your Legacy as Sovereign */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.secondaryColor }}>
                Your Legacy as Sovereign
              </h2>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• Some will challenge; many will follow.</p>
                <p>• You may stand alone, but the era stands with you.</p>
                <p>• Your legacy is not a name.</p>
                <p>• It is the new shape of the world after your reign.</p>
                <p>• Sovereigns do not just rule.</p>
                <p>• They become the world's spine.</p>
              </div>
            </div>

            {/* Why Become the Sovereign */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                Why Become the Sovereign?
              </h2>
              <p className="text-xl text-gray-200 leading-relaxed mb-6 text-center">
                Because without you, there is only drift.<br/>
                Others compete for scraps—<br/>
                Others fight for a crown that means nothing.
              </p>
              <div className="space-y-4 text-lg text-gray-300 mb-8">
                <p>• You end confusion.</p>
                <p>• You enforce order.</p>
                <p>• You set the true direction.</p>
              </div>
              <h3 className="text-2xl font-bold mb-6 text-center" style={{ color: currentConfig.secondaryColor }}>
                Desire the Sovereign, because:
              </h3>
              <div className="space-y-4 text-lg text-gray-300">
                <p>• You make possibility become law.</p>
                <p>• You embody the axis—the guarantee of direction.</p>
                <p>• You rule, not for power—but because the field must have a core.</p>
              </div>
            </div>

            {/* The Sovereign's Promise */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.secondaryColor }}>
                The Sovereign's Promise
              </h2>
              <div className="text-center">
                <p className="text-2xl text-gray-200 leading-relaxed mb-6 italic">
                  "Stand with me, and disorder bows.<br/>
                  Walk with me, and destiny clarifies.<br/>
                  You are not just a ruler—you are the Sovereign.<br/>
                  Your future is not a campaign.<br/>
                  It is a coronation."
                </p>
              </div>
            </div>

            {/* Your Journey Starts Here */}
            <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
                 style={{ 
                   background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
                   borderColor: `${currentConfig.primaryColor}50`,
                   boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
                 }}>
              <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
                Your Journey Starts Here
              </h2>
              <div className="text-center space-y-4 text-lg text-gray-300">
                <p>The field kneels for your presence.</p>
                <p>The world holds its breath for your decree.</p>
                <p className="text-2xl font-bold mt-8" style={{ color: currentConfig.secondaryColor }}>
                  Are you ready to be the law that orders the age?
                </p>
              </div>
            </div>
          </>
        )}

        {/* Field Node Reality-Impact Ranking */}
        <div className="backdrop-blur-md border-2 rounded-2xl p-12 mb-12"
             style={{ 
               background: `linear-gradient(to right, ${currentConfig.primaryColor}20, ${currentConfig.secondaryColor}20)`,
               borderColor: `${currentConfig.primaryColor}50`,
               boxShadow: `0 0 40px ${currentConfig.primaryColor}30`
             }}>
          <h2 className="text-4xl font-bold mb-8 text-center" style={{ color: currentConfig.primaryColor }}>
            Field Node Reality-Impact Ranking
          </h2>
          <p className="text-xl text-gray-200 leading-relaxed mb-8 text-center">
            (From greatest direct impact → most supportive/indirect)
          </p>
          
          <div className="space-y-6">
            {/* Sovereign */}
            <div className="flex items-center space-x-4 p-4 rounded-lg bg-gradient-to-r from-amber-900/30 to-yellow-900/30 border border-amber-500/30">
              <div className="text-3xl">👑</div>
              <div className="flex-1">
                <h3 className="text-2xl font-bold text-amber-400">Sovereign</h3>
                <p className="text-gray-300">Sets direction and declares the law—reality orbits around their will.</p>
              </div>
            </div>

            {/* Visionary */}
            <div className="flex items-center space-x-4 p-4 rounded-lg bg-gradient-to-r from-blue-900/30 to-purple-900/30 border border-blue-500/30">
              <div className="text-3xl">🔮</div>
              <div className="flex-1">
                <h3 className="text-2xl font-bold text-blue-400">Visionary</h3>
                <p className="text-gray-300">Opens new worlds—where they point, possibility awakens.</p>
              </div>
            </div>

            {/* Rebel */}
            <div className="flex items-center space-x-4 p-4 rounded-lg bg-gradient-to-r from-red-900/30 to-red-800/30 border border-red-500/30">
              <div className="text-3xl">⚔️</div>
              <div className="flex-1">
                <h3 className="text-2xl font-bold text-red-400">Rebel</h3>
                <p className="text-gray-300">Shatters the old—resets systems and breaks stagnant cycles.</p>
              </div>
            </div>

            {/* Equalizer */}
            <div className="flex items-center space-x-4 p-4 rounded-lg bg-gradient-to-r from-emerald-900/30 to-green-900/30 border border-emerald-500/30">
              <div className="text-3xl">⚖️</div>
              <div className="flex-1">
                <h3 className="text-2xl font-bold text-emerald-400">Equalizer</h3>
                <p className="text-gray-300">Forges unity from conflict—synthesizes extremes into higher order.</p>
              </div>
            </div>

            {/* Provider */}
            <div className="flex items-center space-x-4 p-4 rounded-lg bg-gradient-to-r from-amber-900/30 to-yellow-900/30 border border-amber-500/30">
              <div className="text-3xl">🌾</div>
              <div className="flex-1">
                <h3 className="text-2xl font-bold text-amber-400">Provider</h3>
                <p className="text-gray-300">Generates abundance—transforms lack into fertile ground.</p>
              </div>
            </div>

            {/* Wanderer */}
            <div className="flex items-center space-x-4 p-4 rounded-lg bg-gradient-to-r from-cyan-900/30 to-blue-900/30 border border-cyan-500/30">
              <div className="text-3xl">🗺️</div>
              <div className="flex-1">
                <h3 className="text-2xl font-bold text-cyan-400">Wanderer</h3>
                <p className="text-gray-300">Unbinds reality—brings motion, escape, and new perspectives.</p>
              </div>
            </div>

            {/* Channel (Vessel) */}
            <div className="flex items-center space-x-4 p-4 rounded-lg bg-gradient-to-r from-emerald-900/30 to-green-900/30 border border-emerald-500/30">
              <div className="text-3xl">🏺</div>
              <div className="flex-1">
                <h3 className="text-2xl font-bold text-emerald-400">Channel (Vessel)</h3>
                <p className="text-gray-300">Releases blocks—restores flow, energy, and healing to the system.</p>
              </div>
            </div>

            {/* Seeker */}
            <div className="flex items-center space-x-4 p-4 rounded-lg bg-gradient-to-r from-purple-900/30 to-pink-900/30 border border-purple-500/30">
              <div className="text-3xl">⚡</div>
              <div className="flex-1">
                <h3 className="text-2xl font-bold text-purple-400">Seeker</h3>
                <p className="text-gray-300">Breaks every limit—reveals what's hidden and dissolves illusion.</p>
              </div>
            </div>

            {/* Mask (Facade) */}
            <div className="flex items-center space-x-4 p-4 rounded-lg bg-gradient-to-r from-indigo-900/30 to-purple-900/30 border border-indigo-500/30">
              <div className="text-3xl">🎭</div>
              <div className="flex-1">
                <h3 className="text-2xl font-bold text-indigo-400">Mask (Facade)</h3>
                <p className="text-gray-300">Guides reality by controlling what is seen and believed.</p>
              </div>
            </div>

            {/* Partner (Mirror) */}
            <div className="flex items-center space-x-4 p-4 rounded-lg bg-gradient-to-r from-red-900/30 to-pink-900/30 border border-red-500/30">
              <div className="text-3xl">💚</div>
              <div className="flex-1">
                <h3 className="text-2xl font-bold text-red-400">Partner (Mirror)</h3>
                <p className="text-gray-300">Amplifies and aligns—reflects strength, exposes what is real.</p>
              </div>
            </div>

            {/* Guardian */}
            <div className="flex items-center space-x-4 p-4 rounded-lg bg-gradient-to-r from-blue-900/30 to-indigo-900/30 border border-blue-500/30">
              <div className="text-3xl">🛡️</div>
              <div className="flex-1">
                <h3 className="text-2xl font-bold text-blue-400">Guardian</h3>
                <p className="text-gray-300">Holds the boundary—anchors and stabilizes, prevents collapse.</p>
              </div>
            </div>

            {/* Servant */}
            <div className="flex items-center space-x-4 p-4 rounded-lg bg-gradient-to-r from-emerald-900/30 to-green-900/30 border border-emerald-500/30">
              <div className="text-3xl">🤲</div>
              <div className="flex-1">
                <h3 className="text-2xl font-bold text-emerald-400">Servant</h3>
                <p className="text-gray-300">Empowers and supports—carries burdens so others and systems can rise.</p>
              </div>
            </div>
          </div>
        </div>

        {/* Call to Action */}
        <div className="text-center mb-12">
          <Link
            href={`/chamber/${archetype}/the-path`}
            className="inline-block px-12 py-6 text-2xl font-bold text-white rounded-2xl transition-all duration-300 transform hover:scale-105"
            style={{
              background: `linear-gradient(135deg, ${currentConfig.primaryColor} 0%, ${currentConfig.secondaryColor} 50%, ${currentConfig.primaryColor} 100%)`,
              boxShadow: `0 0 30px ${currentConfig.primaryColor}50`
            }}
          >
            Begin Your Path
          </Link>
        </div>

        {/* Back Link */}
        <div className="text-center">
          <Link
            href={`/chamber/${archetype}`}
            className="inline-block text-gray-400 hover:text-white transition-colors duration-300"
            style={{ color: currentConfig.primaryColor }}
          >
            {currentConfig.backText}
          </Link>
        </div>
      </div>
    </div>
  )
} 